using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            var car1 = new Car()
            {
                Year = 2016,
                Make = "Ford",
                Model = "Fusion",
                EngineNoise = "vroom vroom",
                HonkNoise = "HONK HONK",
                IsDrivable = true
            };

            var car2 = new Car();

            car2.Year = 1993;
            car2.Make = "Chevy";
            car2.Model = "Prism";
            car2.EngineNoise = "putt putt";
            car2.HonkNoise = "beep beep";
            car2.IsDrivable = false;


            var car3 = new Car( 2021, "Kia", "Stinger", "VROOM! VROOM!", "BEEP BEEP", true );

            //Call each of the methods for each car
            foreach (Car car in CarLot.ListOfCars)
            {
                Console.WriteLine($"\nCar #{CarLot.ListOfCars.IndexOf(car) + 1} goes:\n");
                car.MakeEngineNoise();
                car.MakeHonkNoise();
            }

            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            foreach (Car car in CarLot.ListOfCars)
            {
                Console.WriteLine("\n" +
                    $"Car #{CarLot.ListOfCars.IndexOf(car) + 1}--\n" +
                    $"Year:  {car.Year}\n" +
                    $"Make:  {car.Make}\n" +
                    $"Model: {car.Model}");
            }
        }
    }
}
