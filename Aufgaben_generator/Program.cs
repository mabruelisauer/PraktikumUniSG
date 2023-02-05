using System.Security.Cryptography.X509Certificates;

namespace Aufgaben_generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Input input = new Input();
            Generator generator = new Generator();
            int NumberOfTasksInput = input.GetNumberOfTasks();
            generator.SetNumberOfTasks(NumberOfTasksInput);
            generator.RunProgram();
        }
    }
}