using System.IO;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,long> telefonRehberi = new Dictionary<string, long>();
            int option;

            do
            {
                Console.WriteLine("1-)Display Numbers.");
                Console.WriteLine("2-)Add new number.");
                option = Convert.ToInt32(Console.ReadLine());

            } while (option != 1 && option != 2);

            if (option == 1)
            {
                DisplayNumbers();
                return;
            }
            else if (option == 2)
            {
                AddNewNumber(telefonRehberi);
                
                Console.Clear();
                foreach (var entry in telefonRehberi)    // to write to console all added numbers.
                {
                    string _name = entry.Key;
                    long _number = entry.Value;

                    Console.WriteLine(_name + ": " + _number);
                }
            }

            SortTheNumberList();
        }

        static void DisplayNumbers()
        {
            string[] lines = File.ReadAllLines("Rehber.txt");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }

        static void AddNewNumber(Dictionary<string,long> telefonRehberi)
        {
            string? name;
            long number;
            List<string> texts = new List<string>();
            int option;

            do
            {
                Console.Clear();
                Console.WriteLine("Name:");   // to get the name.
                name = Console.ReadLine();

                Console.WriteLine("Number:");
                number = Convert.ToInt64(Console.ReadLine());   // to get the number.
                
                telefonRehberi.Add(name, number);       // to add the name and number to telefonRehberi.
                string text = name + ": " + number;
                texts.Add(text);

                Console.WriteLine("1-)Add another   2-)Save");
                option = Convert.ToInt32(Console.ReadLine());
                if (option == 2) {break;}
            } while (option == 1);

            File.AppendAllLines("Rehber.txt",texts.ToArray());
        }

        static void SortTheNumberList()
        {
            string[] lines = File.ReadAllLines("Rehber.txt");
            List<string> list_lines = new List<string>();

            foreach (string line in lines)
            {
                list_lines.Add(line);
            }
            list_lines.Sort();

            File.WriteAllLines("Rehber.txt",list_lines.ToArray());

        }

    }
}
