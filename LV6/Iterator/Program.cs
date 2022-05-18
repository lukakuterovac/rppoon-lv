namespace Iterator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Task1();
            Task2();
        }
        static void Task1()
        {
            // Task 1: commented since Iterator was
            // changed to work with Box and Product
            // List<Note> notes = new List<Note>()
            // {
            //     new Note("RPPOON", "LV6"),
            //     new Note("Take a break", ":)"),
            // };
            // IAbstractCollection notebook = new Notebook(notes);
            // IAbstractIterator iterator = notebook.GetIterator();
            // for (iterator.First(); !iterator.IsDone; iterator.Next())
            // {
            //     iterator.Current.Show();
            //     Console.WriteLine();
            // }
        }
        static void Task2()
        {
            List<Product> products = new List<Product>()
            {
                new Product("Coffee", 1.99),
                new Product("Chocolate", 2.30),
            };
            IAbstractCollection box = new Box(products);
            IAbstractIterator iterator = box.GetIterator();
            for (var product = iterator.First(); !iterator.IsDone; product = iterator.Next())
            {
                Console.WriteLine(product);
            }
        }
    }
}