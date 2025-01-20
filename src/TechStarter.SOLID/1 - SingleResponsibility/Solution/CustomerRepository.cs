using Microsoft.Data.SqlClient;
using System.Data;

namespace TechStarter.SOLID._1___SingleResponsibility.Solution
{
    public class CustomerRepository
    {
        public void AddCustomer(Customer customer)
        {
            using var cn = new SqlConnection();
            var cmd = new SqlCommand();

            cn.ConnectionString = "connection_string";
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO customer (NOME, EMAIL CPF, DATACADASTRO) VALUES (@nome, @email, @cpf, @dataCad))";

            cmd.Parameters.AddWithValue("nome", customer.Name);
            cmd.Parameters.AddWithValue("email", customer.Email);

            cn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
