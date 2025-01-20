namespace TechStarter.SOLID._1___SingleResponsibility.Solution
{
    public class Customer
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }

        public bool IsCustomerDataValid()
        {
            return !string.IsNullOrEmpty(Name) && EmailService.IsValid(Email);
        }

    }
}
