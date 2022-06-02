using System;

namespace Observer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Task1();
        }

        static void Task1()
        {
            SimpleSystemDataProvider systemData = new SystemDataProvider();
            Logger consoleLogger = new ConsoleLogger();
            Logger fileLogger = new FileLogger("systemData.txt");
            systemData.Attach(consoleLogger);
            // systemData.Attach(fileLogger);
            for(;;)
            {
                systemData.Notify();
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}