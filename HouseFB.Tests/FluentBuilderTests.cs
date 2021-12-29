using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseFB;

namespace HouseFB.Tests
{
    [TestFixture]
    public class FluentBuilderTests
    {
        private HouseBuilder _testBuilder;
        private House _testHouse;

        [SetUp]
        public void SetUp()
        {
            _testBuilder = new HouseBuilder();
            _testHouse = _testBuilder
                .SetNoOfRooms(3)
                .SetNoOfWindows(2)
                .SetParkingSpaces(4)
                .SetAddress("Testgatan 12")
                .WithSwimmingPool()
                .Build();

        }
        [Test]
        public void SetNoOfRooms_GivenNumber_ReturnsCorrectValue()
        {           
            Assert.AreEqual(3, _testHouse.NoOfRooms);
        }

        [Test]
        public void SetNoOfWindows_GivenNumber_ReturnsCorrectValue()
        {
            Assert.AreEqual(2, _testHouse.NoOfWindows);
        }

        [Test]
        public void SetParkingSpaces_GivenNumber_ReturnsCorrectValue()
        {
            Assert.AreEqual(4, _testHouse.ParkingSpotsInGarage);
        }

        [Test]
        public void SetAddress_GivenString_ReturnsCorrectValue()
        {
            Assert.AreEqual("Testgatan 12", _testHouse.StreetAdress);
        }
        [Test]
        public void WithSwimmingPool_ReturnsTrue()
        {
            Assert.AreEqual(true, _testHouse.HasSwimmingPool);
        }

        [Test]
        public void Build_CheckEvaluations()
        {
            var ex = Assert.Throws<ArgumentException>(() => _testBuilder.SetParkingSpaces(1).SetNoOfRooms(0).Build());
            Assert.That(ex.Message, Is.EqualTo("The house needs atleast one room/window."));

            var ex2 = Assert.Throws<ArgumentException>(() => _testBuilder.SetParkingSpaces(0).SetNoOfRooms(1).SetNoOfWindows(1).Build());
            Assert.That(ex2.Message, Is.EqualTo("You have to have atleast 1 parking spot!"));
        }
    }
}
