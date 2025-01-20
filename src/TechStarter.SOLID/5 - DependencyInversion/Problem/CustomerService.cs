namespace TechStarter.SOLID._5___DependencyInversion.Problem
{
    public class CustomerService
    {
        public string AddCustomer(Customer customer)
        {
            if (!customer.IsValid())
                return "Invalid data.";

            var repo = new CustomerRepository();
            CustomerRepository.AddCustomer(customer);

            EmailService.Enviar("no-reply@witantech.com.br", customer.Email, "Welcome ", "Welcome to our newsletter!");

            return "Customer registered successfully!";
        }
    }
}