using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2Interface.Entities
{
    class Installments
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installments(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"Date: {DueDate.ToString("dd/MM/yyyy")} - Value: {Amount}";
        }
    }
}
