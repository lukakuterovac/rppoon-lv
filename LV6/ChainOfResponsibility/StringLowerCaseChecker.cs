namespace ChainOfResponsibility
{
    class StringLowerCaseChecker : StringChecker
    {
        public StringLowerCaseChecker() : base() { }
        protected override bool PerformCheck(string stringToCheck)
        {
            return stringToCheck.Any(char.IsLower);
        }
    }
}