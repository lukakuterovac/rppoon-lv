using System;

namespace Memento
{
    public class Program
    {
        static void Main(string[] args)
        {
            Task3();
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
    }
}