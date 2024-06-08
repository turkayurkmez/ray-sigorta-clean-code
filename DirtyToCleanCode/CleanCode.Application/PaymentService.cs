using CleanCode.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Application
{
    public class PaymentService
    {
      

        public PaymentService()
        {
           
        }

        public double GetExtraPayment(List<TimeSheetEntry> timeSheetEntries, IPaymentCalculationStrategy strategy)
        {
        
            //double totalExtra = 0;
            double totalHours = timeSheetEntries.Sum(entry => entry.HoursWorked);          
            return strategy.CalculateExtraPayment(totalHours);

        }
    }
}
