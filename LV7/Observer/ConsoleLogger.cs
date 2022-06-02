using System;

namespace Observer
{
    class ConsoleLogger : Logger
    {
        public void Log(SimpleSystemDataProvider provider)
        {
            Console.WriteLine("-> CPU load: " + provider.CPULoad
            + " Available RAM: " + provider.AvailableRAM);
        }
    }
}