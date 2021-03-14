using Exercise2Interface.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2Interface.Services
{
    class ContractServices
    {
        private IOnlinePaymentService _onlinePaymentService;
        Installments installments;
        DateTime date;

        public void ProcessContract(Contract contract, int month, IOnlinePaymentService onlinePaymentService)
        {
            double amountSimple = contract.TotalValue / month;

            for (int i = 1; i <= month; i++)
            {
                double total = onlinePaymentService.Interest(amountSimple, i);

                double amount = onlinePaymentService.PaymentFee(total);

                date = contract.DateContract.Date.AddMonths(i);

                installments = new Installments(date, amount);

                contract.AddItem(installments);
            }
        }
    }
}
