using System.Collections.Generic;
using System;
using Portion.Entities;

namespace Portion.Services
{
    class ContractService
    {
        public Contract Compactar;
        public int Months{get; set;}
        public IOnlinePaymentService Payment{get; set;}
        
        public ContractService()
        {

        }

        public ContractService(Contract contract, int months, IOnlinePaymentService payment)
        {
            Compactar = contract;
            Months = months;
            Payment = payment;
        }

        public void ProcessContract()
        {

            List<Installment> installments = new List<Installment>();
            double portionParcil = Compactar.TotalValeu / Months;

            for (int i = 1; i <= Months; i++)
            { 
                double interest = Payment.Interest(portionParcil, i);
                double fee = Payment.PaymentFee(portionParcil + interest);
                double interestTotal = portionParcil + interest + fee;

                DateTime nextDate = Compactar.Date.AddMonths(i);
                installments.Add(new Installment(nextDate, interestTotal));
            }

            Compactar.Installments = installments;
        }
    }
}