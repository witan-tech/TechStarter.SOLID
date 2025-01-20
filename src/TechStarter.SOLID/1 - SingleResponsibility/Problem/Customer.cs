using Microsoft.Data.SqlClient;
using System.Net;
using System.Net.Mail;

public class Customer
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }

    public string AddCustomer()
    {
        if (string.IsNullOrEmpty(Name))
            return "Name is required";

        if (string.IsNullOrEmpty(Email))
            return "Email is required";

        using (var connection = new SqlConnection("connectionString"))
        {
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO Customers (Id, Name, Email) VALUES (@Id, @Name, @Email)";
                command.Parameters.AddWithValue("@Id", Guid.NewGuid());
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Email", Email);
                command.ExecuteNonQuery();
            }
        }

        var email = new MailMessage(Name, Email, "Welcome", "Welcome to our website!");
        var client = new SmtpClient("smtp.gmail.com", 587);
        client.Credentials = new NetworkCredential("username", "password");
        client.EnableSsl = true;
        client.Send(email);

        return "Customer added successfully";
    }

}
