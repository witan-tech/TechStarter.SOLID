namespace EP.SOLID.ISP.Violacao
{
    public interface IRegister
    {
        void ValidateData();
        void SaveToDatabase();
        void SendEmail();
    }
}