using System;
using System.Globalization;
using Portion.Entities;
using Portion.Services;

namespace Portion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());

            ContractService contract = new ContractService(new Contract(number, date, value), installments, new PalpalService());
            contract.ProcessContract();

            Console.WriteLine("");
            Console.WriteLine("Installments:");
            foreach(Installment doc in contract.Compactar.Installments)
            {
                Console.WriteLine(doc.ToString());
            }
        }
    }
}
