using System.Security.Principal;

namespace Module17
{
    internal class Program
    {
        static void Main()
        {
            GeneralAccount generalAccount = new(999); //Открыли обычный счет и положили 999 денег
            
            Calculator.CalculateInterest(generalAccount);
            Console.WriteLine($@"Ставка счета ""{generalAccount.Type}"" при балансе равном {generalAccount.Balance} составляет {generalAccount.Interest}");

            generalAccount.Balance = 1000; //Доложили денег на счет
            Calculator.CalculateInterest(generalAccount);
            Console.WriteLine($@"Ставка счета ""{generalAccount.Type}"" при балансе равном {generalAccount.Balance} составляет {generalAccount.Interest}");

            SalaryAccount salaryAccount = new(); //Открыли открыли зарплатный счет 
            salaryAccount.Balance = 1000; //положили 1000 денег

            Calculator.CalculateInterest(salaryAccount);
            Console.WriteLine($@"Ставка счета ""{salaryAccount.Type}"" при балансе равном {salaryAccount.Balance} составляет {salaryAccount.Interest}");

            Console.ReadKey();
        }
    }
}