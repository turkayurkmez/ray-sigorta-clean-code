using CleanCode.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Application
{
    public class MailService
    {
        public void SimulatingMail(List<TimeSheetEntry> timeSheetEntries, Company company)
        {
            double totalHours = totalHoursForCompany(timeSheetEntries, company);
            Console.WriteLine("Simulating Sending email to Acme");
            Console.WriteLine("Your bill is $" + totalHours * company.HourlyPrice + " for the hours worked.");
        }

        private double totalHoursForCompany(List<TimeSheetEntry> timeSheetEntries, Company company) =>
             timeSheetEntries
                         .Where(entry => entry.WorkDone.Contains(company.Name, StringComparison.OrdinalIgnoreCase))
                         .Sum(entry => entry.HoursWorked);
    }
}
