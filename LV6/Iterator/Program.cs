

namespace Iterator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Note> notes = new List<Note>()
            {
                new Note("RPPOON", "LV6"),
                new Note("Take a break", ":)"),
            };
            IAbstractCollection notebook = new Notebook(notes);
            IAbstractIterator iterator = notebook.GetIterator();
            for (iterator.First(); !iterator.IsDone; iterator.Next())
            {
                iterator.Current.Show();
                Console.WriteLine();
            }
        }
    }
}