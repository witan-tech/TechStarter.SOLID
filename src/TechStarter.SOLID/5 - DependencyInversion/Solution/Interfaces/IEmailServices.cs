namespace TechStarter.SOLID._5___DependencyInversion.Solution.Interfaces
{
    public interface IEmailServices
    {
        bool IsValid(string email);
        void Enviar(string from, string to, string subject, string message);
    }
}