using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            CarLot.ListOfCars.Add( new Car()
            {
                Year = 2016,
                Make = "Ford",
                Model = "Fusion",
                EngineNoise = "vroom vroom",
                HonkNoise = "HONK HONK",
                IsDrivable = true
            });

            CarLot.ListOfCars.Add( new Car() );

            CarLot.ListOfCars[CarLot.ListOfCars.Count - 1].Year = 1993;
            CarLot.ListOfCars[CarLot.ListOfCars.Count - 1].Make = "Chevy";
            CarLot.ListOfCars[CarLot.ListOfCars.Count - 1].Model = "Prism";
            CarLot.ListOfCars[CarLot.ListOfCars.Count - 1].EngineNoise = "putt putt";
            CarLot.ListOfCars[CarLot.ListOfCars.Count - 1].HonkNoise = "beep beep";
            CarLot.ListOfCars[CarLot.ListOfCars.Count - 1].IsDrivable = false;

            CarLot.ListOfCars.Add( new Car( 2021, "Kia", "Stinger", "VROOM! VROOM!", "BEEP BEEP", true ) );

            CarLot.ListOfCars.Add(new Car());

            //Call each of the methods for each car
            foreach (Car car in CarLot.ListOfCars)
            {
                if (car.EngineNoise != null && car.HonkNoise != null)
                {
                    Console.WriteLine($"\nCar #{CarLot.ListOfCars.IndexOf(car) + 1} goes:\n");
                    car.MakeEngineNoise();
                    car.MakeHonkNoise();
                } 
            }

            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            foreach (Car car in CarLot.ListOfCars)
            {
                Console.WriteLine("\n" +
                    $"Car #{CarLot.ListOfCars.IndexOf(car) + 1}--\n" +
                    "Year:  " + (car.Year > 0 ? $"{car.Year}\n" : "Unknown\n") +
                    "Make:  " + (car.Make != null ? $"{car.Make}\n" : "Unknown\n") +
                    "Model: " + (car.Model != null ? $"{car.Model}\n" : "Unknown\n"));
            }
        }
    }
}
