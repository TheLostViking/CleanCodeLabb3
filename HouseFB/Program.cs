using HouseFB;

HouseBuilder houseBuilder = new HouseBuilder();
House house = houseBuilder
        .SetNoOfRooms(2)
        .SetNoOfWindows(2)
        .SetAddress("Vintergatan 16")
        .SetParkingSpaces(3)
        .Build();


Console.WriteLine(house);