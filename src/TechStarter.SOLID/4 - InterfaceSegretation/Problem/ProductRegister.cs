using System;

namespace EP.SOLID.ISP.Violacao
{
    public class ProductRegister : IRegister
    {
        public void ValidateData()
        {
            // Validar valor
        }

        public void SaveToDatabase()
        {
            // Insert tabela Produto
        }

        public void SendEmail()
        {
            // Product não envia e-mail, mas está no contrato via interface
        }
    }
}