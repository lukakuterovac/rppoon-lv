using System;

namespace Memento
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 3:");
            Task3();
            Console.WriteLine("\n\nTask 4:");
            Task4();
        }
        static void Task3()
        {
            CareTaker careTaker = new CareTaker();
            ToDoItem item = new ToDoItem("RPPOON LV6", "Finish LV6", DateTime.Now.AddDays(1));
            Console.WriteLine("Before change: \n" + item);

            careTaker.PreviousState = item.StoreState();
            item.Rename("Shopping list");
            item.ChangeTask("Buy milk");
            item.ChangeTimeDue(DateTime.Now.AddDays(2));
            Console.WriteLine("After 1. change: \n" + item);

            careTaker.PreviousState = item.StoreState();
            item.Rename("Workout");
            item.ChangeTask("Go to the gym");
            item.ChangeTimeDue(DateTime.Now.AddHours(2));
            Console.WriteLine("After 2. change: \n" + item);
            
            item.RestoreState(careTaker.PreviousState);
            Console.WriteLine("After 1. restore: \n" + item);

            item.RestoreState(careTaker.PreviousState);
            Console.WriteLine("After 2. restore: \n" + item);
        }
        static void Task4()
        {
            BankAccount bankAccount = new BankAccount("Luka", "Vinkovci", 20.00m);
            BankAccountCareTaker careTaker = new BankAccountCareTaker();
            careTaker.PreviousState = bankAccount.StoreState();
            Console.WriteLine("Before adding funds: ");
            PrintBankAccount(bankAccount);
            careTaker.PreviousState = bankAccount.StoreState();

            bankAccount.UpdateBalance(700);
            Console.WriteLine("After adding funds: ");
            PrintBankAccount(bankAccount);

            bankAccount.RestoreState(careTaker.PreviousState);
            Console.WriteLine("After restoring previous state: ");
            PrintBankAccount(bankAccount);
        }

        static void PrintBankAccount(BankAccount account)
        {
            Console.WriteLine(account.OwnerName + ", " + account.OwnerAddress + "\nBalance: " + account.Balance);
        }
    }
}