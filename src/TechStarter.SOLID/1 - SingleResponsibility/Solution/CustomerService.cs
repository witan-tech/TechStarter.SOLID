namespace TechStarter.SOLID._1___SingleResponsibility.Solution
{
    public class CustomerService
    {
        public string AddCustomer(Customer customer)
        {
            if (!customer.IsCustomerDataValid())
            {
                return "Invalid customer data.";
            }

            var repository = new CustomerRepository();
            repository.AddCustomer(customer);

            EmailService.Send("no-reply@witantech.com.br", customer.Email, "Welcome", "Welcome to our platform!");

            return "Customer registered successfully!";
        }
    }
}
