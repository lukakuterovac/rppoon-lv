namespace ChainOfResponsibility
{
    class StringUpperCaseChecker : StringChecker
    {
        public StringUpperCaseChecker() : base() { }
        protected override bool PerformCheck(string stringToCheck)
        {
            return stringToCheck.Any(char.IsUpper);
        }
    }
}