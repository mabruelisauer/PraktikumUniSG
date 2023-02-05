using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben_generator
{
    internal class Task
    {
        Input input = new Input();
        public double Number1 { get; set; }
        public string Operator { get; set; }
        public double Number2 { get; set; }
        public double Result { get; set; }

        public Task(double number1, string @operator, double number2)
        {
            Number1 = number1;
            Operator = @operator;
            Number2 = number2;
        }

        public void CalculateTask()
        {
            if (Operator == "+")
            {
                Result = Number1 + Number2;
            }
            if (Operator == "-")
            {
                Result = Number1 - Number2;
            }
            if (Operator == "*")
            {
                Result = Number1 * Number2;
            }
            if (Operator == "/")
            {
                Result = Number1 / Number2;
                Result = Math.Round(Result, 2);
            }
            input.PrintTaskAndCheckAnswer(Number1, Operator, Number2, Result);
        }
    }
}
