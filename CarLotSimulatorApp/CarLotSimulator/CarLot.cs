using System;
using System.Collections.Generic;
using System.Text;

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
