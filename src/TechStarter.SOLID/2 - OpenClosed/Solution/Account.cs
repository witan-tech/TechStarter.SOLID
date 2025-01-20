namespace TechStarter.SOLID._2___OpenClosed.Solution
{
    public abstract class Account
    {
        public Guid TransactionId { get; set; }
        public abstract string Debit(decimal value, string accountId);
    }
}
