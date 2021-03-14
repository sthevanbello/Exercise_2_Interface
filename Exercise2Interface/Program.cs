using Exercise2Interface.Entities;
using Exercise2Interface.Services;
using System;
using System.Globalization;

namespace Exercise2Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data: ");

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Date: ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Contract value: ");
            double totalValue = double.Parse(Console.ReadLine());

            Console.Write("Enter the number of installments: ");
            int numberInstallments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, totalValue);

            ContractServices contractServices = new ContractServices();

            contractServices.ProcessContract(contract, numberInstallments, new Paypal());


            foreach (var item in contract.Installments)
            {
                Console.WriteLine(item);
            }



            Console.ReadKey();

        }
    }
}
