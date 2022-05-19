namespace ChainOfResponsibility
{
    class PasswordValidator
    {
        private StringChecker firstChecker;
        private StringChecker lastChecker;
        public PasswordValidator(StringChecker stringChecker)
        {
            firstChecker = stringChecker;
            lastChecker = stringChecker;
        }
        public void SetNextChecker(StringChecker stringChecker)
        {
            lastChecker.SetNext(stringChecker);
            lastChecker = stringChecker;
        }
        public bool Validate(string password)
        {
            return firstChecker.Check(password);
        }
    }
}