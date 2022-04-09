using CommandPattern.Interfaces;

namespace CommandPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();
            // Execute Animal Command
            ICommand command = invoker.GetCommand("Animal");
            command.Execute();
            // Execute People Commad
            command = invoker.GetCommand("People");
            command.Execute();
            Console.WriteLine("Command Pattern demo");
            Console.Read();
        }
    }
}