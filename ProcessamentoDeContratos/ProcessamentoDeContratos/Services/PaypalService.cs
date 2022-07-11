using System;
using System.Globalization;

namespace ProcessamentoDeContratos.Services
{
    class PaypalService : IOnlinePaymentService
    {        
        public double Interest(double amount, int months)
        {
            return amount * 0.01 * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * 0.02;
        }        
    }
}
