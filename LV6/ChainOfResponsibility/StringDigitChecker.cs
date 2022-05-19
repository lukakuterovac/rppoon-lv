namespace ChainOfResponsibility
{
    class StringDigitChecker : StringChecker
    {
        public StringDigitChecker() : base() { }
        protected override bool PerformCheck(string stringToCheck)
        {
            return stringToCheck.Any(char.IsDigit);
        }
    }
}