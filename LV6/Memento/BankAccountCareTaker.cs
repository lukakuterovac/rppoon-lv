namespace Memento
{
    class BankAccountCareTaker
    {
        private List<BankAccountMemento> previousState = new List<BankAccountMemento>();
        public BankAccountMemento PreviousState
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
                Console.WriteLine(state.OwnerName + " " + state.Balance);
            }
        }
    }
}