using NUnit.Framework;

namespace HouseF.Tests
{
    public class HouseFactoryTests
    {
        private HouseFactory _testFactory;
        
        [SetUp]
        public void Setup()
        {
           _testFactory = new HouseFactory();
        }

        [Test]
        public void HouseFactory_LowCostHouse_ReturnsCorrectType()
        {
            House testHouse = _testFactory.CreateHouse("lowcosthouse");


            Assert.That(testHouse.NoOfRooms, Is.EqualTo(2));
            Assert.That(testHouse.NoOfWindows, Is.EqualTo(4));
            Assert.That(testHouse.HasSwimmingPool, Is.False);
            Assert.That(testHouse.ParkingSpotsInGarage, Is.EqualTo(1));
        }

        [Test]
        public void HouseFactory_MediumCostHouse_ReturnsCorrectType()
        {
            House testHouse = _testFactory.CreateHouse("mediumcosthouse");


            Assert.That(testHouse.NoOfRooms, Is.EqualTo(3));
            Assert.That(testHouse.NoOfWindows, Is.EqualTo(6));
            Assert.That(testHouse.HasSwimmingPool, Is.False);
            Assert.That(testHouse.ParkingSpotsInGarage, Is.EqualTo(2));
        }

        [Test]
        public void HouseFactory_HighCostHouse_ReturnsHouseOfCorrectType()
        {
            House testHouse = _testFactory.CreateHouse("highcosthouse");


            Assert.That(testHouse.NoOfRooms, Is.EqualTo(5));
            Assert.That(testHouse.NoOfWindows, Is.EqualTo(10));
            Assert.That(testHouse.HasSwimmingPool, Is.True);
            Assert.That(testHouse.ParkingSpotsInGarage, Is.EqualTo(4));
        }

        [Test]
        public void HouseFactory_BigMansion_ReturnsHouseOfCorrectType()
        {
            House testHouse = _testFactory.CreateHouse("bigmansion");


            Assert.That(testHouse.NoOfRooms, Is.EqualTo(10));
            Assert.That(testHouse.NoOfWindows, Is.EqualTo(30));
            Assert.That(testHouse.HasSwimmingPool, Is.True);
            Assert.That(testHouse.ParkingSpotsInGarage, Is.EqualTo(12));
        }
    }
}