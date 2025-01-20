namespace TechStarter.SOLID._5___DependencyInversion.Problem
{
    public class Customer
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }

        public bool IsValid()
        {
            return EmailService.IsValid(Email);
        }
    }
}