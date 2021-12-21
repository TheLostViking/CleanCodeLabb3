using HouseF.Houses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HouseF
{
    public class HouseFactory
    {
        private readonly Dictionary<string, Type> _houses;

        public HouseFactory()
        {
            _houses = LoadHousesReflection();
        }
        public House CreateHouse(string houseType)
        {
           return GetHouseFromDictionary(houseType.ToLower());
        }
        private House GetHouseFromDictionary(string houseType)
        {
            Type type = _houses[houseType];
            if (type is null)
            {
                throw new ArgumentException("Could not find housetype with name " + houseType);
            }
            return (House)Activator.CreateInstance(type);
        }
        
        private Dictionary<string, Type> LoadHousesReflection()
        {
            IEnumerable<Type> availableTypes = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.IsClass && t.IsSubclassOf(typeof(House)));

            Dictionary<string, Type> availableHouses = new();
            foreach (Type t in availableTypes)
            {
                availableHouses.Add(t.Name.ToLower(), t);
            }

            return availableHouses;
        }
    }
}
