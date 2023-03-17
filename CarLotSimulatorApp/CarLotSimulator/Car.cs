using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine($"The cars engine goes {engineNoise}");
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine($"The car's horn goes {honkNoise}");
        }

    }
}   
