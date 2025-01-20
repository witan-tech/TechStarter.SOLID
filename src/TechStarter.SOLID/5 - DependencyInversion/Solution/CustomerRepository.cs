using Microsoft.Data.SqlClient;
using System.Data;
using TechStarter.SOLID._5___DependencyInversion.Solution.Interfaces;

namespace TechStarter.SOLID._5___DependencyInversion.Solution
{
    public class CustomerRepository : ICustomerRepository
    {
        public void AddCustomer(Customer customer)
        {

            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "MinhaConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CLIENTE (NOME, EMAIL) VALUES (@nome, @email))";

                cmd.Parameters.AddWithValue("nome", customer.Name);
                cmd.Parameters.AddWithValue("email", customer.Email);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

        }
    }
}