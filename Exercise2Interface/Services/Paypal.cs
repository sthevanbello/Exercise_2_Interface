using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2Interface.Services
{
    class Paypal : IOnlinePaymentService
    {
        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;
        public double PaymentFee(double amount)
        {
            double total = amount + (amount * FeePercentage);
            return total;
        }

        public double Interest(double amount, int months)
        {
            double total = amount + (amount * MonthlyInterest * months);

            return total;
        }

    }
}
