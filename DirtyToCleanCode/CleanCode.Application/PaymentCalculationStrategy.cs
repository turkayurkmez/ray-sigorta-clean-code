using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Application
{
    public class PaymentCalculationStrategy : IPaymentCalculationStrategy
    {

        private readonly ExtraPaymentOption extraPaymentOption;

        public PaymentCalculationStrategy(ExtraPaymentOption extraPaymentOption)
        {
            this.extraPaymentOption = extraPaymentOption;
        }

        public double CalculateExtraPayment(double totalHours)
        {

            double totalExtra = 0;
            if (totalHours > extraPaymentOption.MaxHourInAWeek)
            {
                var extraTime = totalHours - extraPaymentOption.MaxHourInAWeek;
                totalExtra = extraTime * extraPaymentOption.ExtraPrice;
                totalHours -= extraTime;
            }

            totalExtra += totalHours * extraPaymentOption.StandardPrice;
            return totalExtra;
        }
    }
}
