using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben_generator
{
    internal class Input
    {
        public int GetNumberOfTasks()
        {
                Console.WriteLine("Lösen sie die Aufgaben und runden sie bei Divisionen auf 2 Nachkommastellen.\n");
                Console.WriteLine("Wie viele Aufgaben möchtst du gestellt bekommen?");
                string input = Console.ReadLine();
                while (!Int32.TryParse(input, out int n) || Convert.ToInt32(input) < 0)
                {
                    Console.WriteLine("Bitte gib eine positive Zahl ein!");
                    input = Console.ReadLine();
                }
                int inputNumeric = Convert.ToInt32(input);
            return inputNumeric;
        }
        public void PrintTask(double Number1, string Operator, double Number2)
        {
            Console.WriteLine($"{Number1} {Operator} {Number2} =");
        }
        public void PrintTaskAndCheckAnswer(double Number1, string Operator, double Number2, double Result)
        {
            PrintTask(Number1, Operator, Number2);
            string SInput = Console.ReadLine();
            while (!double.TryParse(SInput, out double n))
            {
                Console.WriteLine("Die Eingabe ist ungültig bitte versuchen sie es erneut.");
                SInput = Console.ReadLine();
            }
            double input = Convert.ToDouble(SInput);

            if (input != Result)
            {
                Console.Clear();
                Console.WriteLine("Ihre Antwort ist nicht richtig! Versuchen sie es erneut.");
                PrintTaskAndCheckAnswer(Number1, Operator, Number2, Result);
            }
            else
            {
                Console.WriteLine("Korrekt!");
            }
        }
    }
}
