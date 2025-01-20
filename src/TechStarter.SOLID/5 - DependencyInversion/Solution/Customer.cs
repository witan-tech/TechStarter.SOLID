using TechStarter.SOLID._5___DependencyInversion.Solution.Interfaces;

namespace TechStarter.SOLID._5___DependencyInversion.Solution
{
    public class Customer
    {
        private readonly IEmailServices _emailServices;

        public Customer(
            IEmailServices emailServices)
        {
            _emailServices = emailServices;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public bool IsValid()
        {
            return _emailServices.IsValid(Email);
        }
    }
}