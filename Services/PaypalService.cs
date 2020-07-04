namespace Portion.Services
{
    class PalpalService : IOnlinePaymentService
    {
        public PalpalService()
        {

        }

        public double PaymentFee(double amount)
        {
            return amount * 2 / 100;
        }

        public double Interest(double amount, int months)
        {
            double interest = (amount * 0.01) * months;
            return interest;
        }
    }
}