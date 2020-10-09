using System;

namespace DIP
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("\t\t\t\tUse Cases of Dependency Inversion Principle");

            var monitor = new Monitor(new HdmiConnector());
            monitor.GeneratePort();
            monitor.StarMonitor();
            Console.ReadKey(true);
        }
    }
}
