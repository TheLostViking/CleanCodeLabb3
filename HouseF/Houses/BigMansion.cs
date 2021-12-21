using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseF
{
    public class BigMansion : House
    {
        public BigMansion()
        {
            NoOfRooms = 10;
            NoOfWindows = 30;
            HasSwimmingPool = true;
            StreetAdress = "On Top Of A Hill 6";
            ParkingSpotsInGarage = 12;
        }
    }
}
