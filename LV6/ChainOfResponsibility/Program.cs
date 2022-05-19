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
            Console.WriteLine("\n\nTask 7: ");
            Task7();
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
        static void Task7()
        {
            StringDigitChecker digitChecker = new StringDigitChecker();
            PasswordValidator passwordValidator = new PasswordValidator(digitChecker);
            StringUpperCaseChecker upperCaseChecker = new StringUpperCaseChecker();
            StringLowerCaseChecker lowerCaseChecker = new StringLowerCaseChecker();
            StringLengthChecker lengthChecker = new StringLengthChecker(6);
            passwordValidator.SetNextChecker(upperCaseChecker);
            passwordValidator.SetNextChecker(lowerCaseChecker);
            Console.WriteLine(passwordValidator.Validate("Ab12"));
            passwordValidator.SetNextChecker(lengthChecker);
            Console.WriteLine(passwordValidator.Validate("Ab12"));
            Console.WriteLine(passwordValidator.Validate("Abcde12"));
        }
    }
}