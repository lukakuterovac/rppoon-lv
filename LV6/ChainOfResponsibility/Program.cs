namespace ChainOfResponsibility
{
    public class Program
    {
        static void Main(string[] args)
        {
            Task5();
        }
        static void Task5()
        {
            AbstractLogger logger = new ConsoleLogger(MessageType.ALL);
            FileLogger fileLogger = new FileLogger(MessageType.ERROR | MessageType.WARNING, "logFile.txt");
            logger.SetNextLogger(fileLogger);
            logger.Log("Error 404", MessageType.ERROR);
        }
    }
}