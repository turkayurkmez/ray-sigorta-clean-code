using CleanCode.Application;
using CleanCode.Entities;

namespace CleanCode
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TimeSheetEntry> timeSheetEntries = getTimeSheetEntriesFromUser();           
            MailService mailService = new MailService();

            var companies = new CompanyService().GetCompanies();
            companies.ForEach(company => mailService.SimulatingMail(timeSheetEntries, company));

            ExtraPaymentOption paymentOption = new ExtraPaymentOption() { MaxHourInAWeek = 40, ExtraPrice = 15, StandardPrice = 10 };
            PaymentService paymentService = new PaymentService();

            var extraPrice = paymentService.GetExtraPayment(timeSheetEntries,new PaymentCalculationStrategy(paymentOption));

            Console.WriteLine("You will get paid $" + extraPrice + " for your work.");
            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }


        static List<TimeSheetEntry> getTimeSheetEntriesFromUser()
        {
            bool cont = false;
            List<TimeSheetEntry> timeSheetEntries = new List<TimeSheetEntry>();
            string answer = string.Empty;
            do
            {
                Console.Write("Enter what you did: ");
                string workDescription = Console.ReadLine();

                double timeForWork = getTimeFromUserAnswer();


                TimeSheetEntry timeSheetEntry = new TimeSheetEntry
                {
                    HoursWorked = timeForWork,
                    WorkDone = workDescription
                };
                timeSheetEntries.Add(timeSheetEntry);
                Console.Write("Do you want to enter more time (yes/no): ");

                answer = Console.ReadLine();

            } while (answer.ToLower() == UserAnswers.YES);



            return timeSheetEntries;
        }

        static double getTimeFromUserAnswer()
        {

            double timeForWork;
            bool isParsedToDouble = true;
            do
            {
                if (!isParsedToDouble)
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine("Invalid number given");
                }
                Console.Write("How long did you do it for: ");
                string rawTimeWorked = Console.ReadLine();
                isParsedToDouble = double.TryParse(rawTimeWorked, out timeForWork);

            } while (!isParsedToDouble);

            return timeForWork;


        }

       

       

     
    }
}
