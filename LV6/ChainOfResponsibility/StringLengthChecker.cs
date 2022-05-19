namespace ChainOfResponsibility
{
    class StringLengthChecker : StringChecker
    {
        private int minimumLength;
        public StringLengthChecker(int minimumLength) : base()
        {
            this.minimumLength = minimumLength;
        }
        protected override bool PerformCheck(string stringToCheck)
        {
            return stringToCheck.Length >= this.minimumLength;
        }
    }
}