using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trasnformation
{
    class Program
    {

        static void Main(string[] args)
        {
            Cars araba = new Cars();
            araba.wheel = 4;
            araba.motorPower = 1.5;
            araba.gearType = "manual";
            araba.fuelType = "diesel";

            Motors motor = new Motors();
            motor = JsonConvert.DeserializeObject<Motors>(JsonConvert.SerializeObject(araba));

            motor.blabla = "aaa";
            motor.windows = 6;

            
            Console.WriteLine(motor.wheel + "\n" + motor.motorPower + "\n" + motor.gearType + "\n" + motor.fuelType+"\n"+motor.blabla+"\n"+motor.windows);
            Console.ReadLine();
        }
    }
}
