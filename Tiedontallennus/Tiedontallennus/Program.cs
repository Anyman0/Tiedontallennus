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
            int temperature;
            Console.Write("Give a new temperature: ");
            string value = Console.ReadLine();
            temperature = int.Parse(value);

            // Saving the given value to a file
            string file = @"C:\Users\User\Desktop\Projects\temp.txt";
            File.WriteAllText(file, temperature.ToString());
            Console.WriteLine("new temperature saved.");

            Console.ReadLine();
        }
    }
}
