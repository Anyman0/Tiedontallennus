using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

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
            Console.WriteLine("new temperature saved. Press enter to read nonsense.");

            Console.ReadLine();

            // XML-file reader TEST
            XmlTextReader reader = new XmlTextReader("Nonsense.xml");
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.
                        Console.Write("<" + reader.Name);
                        Console.WriteLine(">");
                        break;
                    case XmlNodeType.Text: //Display the text in each element.
                        Console.WriteLine(reader.Value);
                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.
                        Console.Write("</" + reader.Name);
                        Console.WriteLine(">");
                        break;
                }
            }
            
            Console.ReadLine();
        }
    }
}
