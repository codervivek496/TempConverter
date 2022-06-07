using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConversion1
{
    internal class CelToFore
    {
        public void CelToFor()
        {
            Console.Write("Enter the input to convert Celcious to Farenheit");
            double cel = Convert.ToDouble(Console.ReadLine());

            cel = Math.Round(cel * 9 / 5);
            Console.WriteLine(cel);
        }

    }
}
