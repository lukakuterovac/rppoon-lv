using System;

namespace Memento
{
    class CareTaker
    {
        private List<Memento> previousState = new List<Memento>();
        public Memento PreviousState
        {
            get
            {
                if (previousState.Count == 0) { return null; }
                var state = this.previousState[this.previousState.Count - 1];
                this.previousState.RemoveAt(this.previousState.Count - 1);
                return state;
            }
            set { this.previousState.Add(value); }
        }

        public void ShowHistory()
        {
            foreach (var state in previousState)
            {
                Console.WriteLine(state.Title + "\t" + state.Text);
            }
        }
    }
}