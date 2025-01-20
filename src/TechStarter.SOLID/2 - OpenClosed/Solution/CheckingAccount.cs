namespace TechStarter.SOLID._2___OpenClosed.Solution
{
    public class CheckingAccount : Account
    {
        public override string Debit(decimal value, string accountId)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("The debit value should be greater than zero");
            }

            if (string.IsNullOrEmpty(accountId))
            {
                return "Account ID cannot be null";
            }

            //implement logic to debit from checking account

            return Guid.NewGuid().ToString();
        }
    }
}
