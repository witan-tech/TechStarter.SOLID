using TechStarter.SOLID._5___DependencyInversion.Solution.Interfaces;

namespace TechStarter.SOLID._5___DependencyInversion.Solution
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IEmailServices _emailServices;

        public CustomerService(
            IEmailServices emailServices,
            ICustomerRepository customerRepository)
        {
            _emailServices = emailServices;
            _customerRepository = customerRepository;
        }

        public string AddCustomer(Customer customer)
        {
            if (!customer.IsValid())
                return "Dados inválidos";

            _customerRepository.AddCustomer(customer);

            _emailServices.Enviar("empresa@empresa.com", customer.Email, "Bem Vindo", "Parabéns está Cadastrado");

            return "customer cadastrado com sucesso";
        }
    }
}