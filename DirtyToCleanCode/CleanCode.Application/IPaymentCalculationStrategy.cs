namespace CleanCode.Application
{
    public interface IPaymentCalculationStrategy
    {
        double CalculateExtraPayment(double totalHours);
    }
}