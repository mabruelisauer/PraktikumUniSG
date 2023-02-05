using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben_generator
{
    internal class Generator
    {
        public static int NumberOfTasks;
        string[] Operators = {"+", "-", "/", "*"};
        //int[] ANumberOfTasks;

        //List<string, List<string>> Tasks = new List<string, List<string>>();

        public void SetNumberOfTasks(int NumberOfTasksInput)
        {
            NumberOfTasks = NumberOfTasksInput;
            //int[] aNumberOfTasks = Enumerable.Range(0, (NumberOfTasks * 2) + 1).ToArray();
            //ANumberOfTasks = aNumberOfTasks;
        }

        public void RunProgram()
        {
            for (int i = 0; i < NumberOfTasks; i++)
            {
                Random rand = new Random();
                double Number1 = rand.Next(500);

                string Operator = Operators[rand.Next(0,4)];

                double Number2 = rand.Next(500);

                AddAndCalculateTask(Number1, Operator, Number2);
            }
        }
        public void AddAndCalculateTask(double Number1, string Operator, double Number2)
        {
            Task task = new Task(Number1, Operator, Number2);
            task.CalculateTask();
        }
    }
}
