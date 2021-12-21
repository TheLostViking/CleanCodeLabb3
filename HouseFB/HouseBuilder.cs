using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseFB
{    
    public class HouseBuilder
    {
        private House _house = new();

        public HouseBuilder SetNoOfWindows (int noOfWindows)
        {
            _house.NoOfWindows = noOfWindows;
            return this;
        }
        public HouseBuilder SetNoOfRooms (int noOfRooms)
        {
            _house.NoOfRooms = noOfRooms;
            return this;
        }
        public HouseBuilder SetParkingSpaces (int noOfParkingSpaces)
        {
            _house.ParkingSpotsInGarage = noOfParkingSpaces;
            return this;
        }
        
        public HouseBuilder SetAddress (string streetAddress)
        {
            _house.StreetAdress = streetAddress;
            return this;
        }

        public HouseBuilder WithSwimmingPool()
        {
            _house.HasSwimmingPool = true;
            return this;
        }
        public House Build()
        {
            if(_house.ParkingSpotsInGarage <= 0)
            {
                throw new ArgumentException("You have to have atleast 1 parking spot!");
            }
            if(_house.NoOfWindows <= 0 || _house.NoOfRooms <= 0)
            {
                throw new ArgumentException("The house needs atleast one room/window.");
            }
            return _house;
        } 
    }
}
