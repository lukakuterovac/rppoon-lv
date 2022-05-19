namespace ChainOfResponsibility
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 5: ");
            Task5();
            Console.WriteLine("\n\nTask 6: ");
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
            StringChecker digitChecker = new StringDigitChecker();
            StringLengthChecker lengthChecker = new StringLengthChecker(6);
            digitChecker.SetNext(lengthChecker);
            StringUpperCaseChecker upperCaseChecker = new StringUpperCaseChecker();
            lengthChecker.SetNext(upperCaseChecker);
            StringLowerCaseChecker lowerCaseChecker = new StringLowerCaseChecker();
            upperCaseChecker.SetNext(lowerCaseChecker);
            Console.WriteLine(digitChecker.Check("ABCd123"));
        }
    }
}