using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tiedontallennus
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"C:\Users\User\Desktop\Projects\temp.txt";

            // Reading the possible previously added temperature value
            if (File.Exists(file))
            {
                string previousTemp = File.ReadAllText(file);
                Console.WriteLine("Previously added temperature is: " + previousTemp + " degrees.");
            }
            else
            {
                Console.WriteLine("Welcome to the temperature application.");
            }

            int temperature;
            Console.Write("Give a new temperature: ");
            string value = Console.ReadLine();
            temperature = int.Parse(value);

            // Saving the given value to a file           
            File.WriteAllText(file, temperature.ToString());
            Console.WriteLine("new temperature saved.");

            Console.ReadLine();
        }
    }
}
