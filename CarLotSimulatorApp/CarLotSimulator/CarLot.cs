using System.Collections.Generic;

namespace CarLotSimulator
{
    public static class CarLot
    {
        static CarLot()
        {
            CarLot.ListOfCars = new List<Car>();
        }

        public static List<Car> ListOfCars { get; set; }
    }
}
