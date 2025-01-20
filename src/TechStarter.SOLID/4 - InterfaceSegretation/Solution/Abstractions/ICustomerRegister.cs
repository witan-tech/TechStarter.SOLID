namespace TechStarter.SOLID._4___InterfaceSegretation.Solution.Abstractions
{
    internal interface ICustomerRegister
    {
        void ValidateData();
        void SaveToDatabase();
        void SendEmail();
    }
}
