using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2Interface.Services
{
    class Paypal : IOnlinePaymentService
    {

        public double PaymentFee(double amount)
        {
            double total = amount + (amount * 0.02);
            return total;
        }

        public double Interest(double amount, int months)
        {
            double total = amount + (amount * 0.01 * months);

            return total;
        }

    }
}
