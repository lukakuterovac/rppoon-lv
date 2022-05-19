namespace ChainOfResponsibility
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Task5();
            Task6();
        }
        static void Task5()
        {
            AbstractLogger logger = new ConsoleLogger(MessageType.ALL);
            FileLogger fileLogger = new FileLogger(MessageType.ERROR | MessageType.WARNING, "logFile.txt");
            logger.SetNextLogger(fileLogger);
            logger.Log("Error 404", MessageType.ERROR);
        }
        static void Task6()
        {
            StringChecker checker = new StringDigitChecker();
            Console.WriteLine(checker.Check("abc1"));
        }
    }
}