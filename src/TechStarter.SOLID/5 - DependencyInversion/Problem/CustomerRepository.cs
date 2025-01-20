using Microsoft.Data.SqlClient;
using System.Data;

namespace TechStarter.SOLID._5___DependencyInversion.Problem
{
    public class CustomerRepository
    {
        public static void AddCustomer(Customer cliente)
        {
            using var cn = new SqlConnection();
            var cmd = new SqlCommand();

            cn.ConnectionString = "MinhaConnectionString";
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO CLIENTE (NOME, EMAIL CPF, DATACADASTRO) VALUES (@nome, @email))";

            cmd.Parameters.AddWithValue("nome", cliente.Name);
            cmd.Parameters.AddWithValue("email", cliente.Email);

            cn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}