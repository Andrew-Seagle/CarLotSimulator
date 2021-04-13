using System;

namespace CarLotSimulator
{
    public class Car
    {
        public Car( int year = 0, string make = null, string model = null, string engineNoise = null, string honkNoise = null, bool isDrivable = true)
        {
            this.Year = year;
            this.Make = make;
            this.Model = model;
            this.EngineNoise = engineNoise;
            this.HonkNoise = honkNoise;
            this.IsDrivable = isDrivable;
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }

        public void MakeEngineNoise ()
        {
            if (EngineNoise != null)
                Console.WriteLine(EngineNoise);
        }

        public void MakeHonkNoise ()
        {
            if (HonkNoise != null)
                Console.WriteLine(HonkNoise);
        }
    }
}
