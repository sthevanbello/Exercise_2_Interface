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
        

        public void ProcessContract(Contract contract, int month, IOnlinePaymentService onlinePaymentService)
        {
            double amountSimple = contract.TotalValue / month;

            for (int i = 1; i <= month; i++)
            {
                double updateAmount = onlinePaymentService.Interest(amountSimple, i);

                double amountTotal = onlinePaymentService.PaymentFee(updateAmount);

                DateTime date = contract.DateContract.Date.AddMonths(i);

                contract.AddItem(new Installments(date, amountTotal));
            }
        }
    }
}
