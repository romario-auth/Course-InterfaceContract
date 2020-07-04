using System;
using System.Collections.Generic;
using Portion.Services;

namespace Portion.Entities
{
    class Contract
    {
        public int Number{get; set;}
        public DateTime Date{get; set;}
        public double TotalValeu{get; set;}
        public List<Installment> Installments = new List<Installment>();

        public Contract()
        {

        }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValeu = totalValue;
        }
    }
}