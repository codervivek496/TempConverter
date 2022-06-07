using System;
namespace TempConversion1
{
    class program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n1. Celcious to Fahrenheit");
                Console.WriteLine("2. Fahrengeit to celcious");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        CelToFore celToFore = new CelToFore();
                        celToFore.CelToFor();
                        break;
                    case 2:
                        ForToCel forToCel = new ForToCel();
                        forToCel.FarenToCel();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Please enter correct choice");
                        break;

                }

        
       
    }
}