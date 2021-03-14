using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2Interface.Entities
{
    class Contract
    {
        public int NumberOfContract { get; set; }
        public DateTime DateContract { get; set; }
        public double TotalValue { get; set; }

        public List<Installments> Installments = new List<Installments>();

        public Contract(int numberOfContract, DateTime dateContract, double totalValue)
        {
            NumberOfContract = numberOfContract;
            DateContract = dateContract;
            TotalValue = totalValue;
        }

        public void AddItem(Installments installments)
        {
            Installments.Add(installments);
        }
    }
}
