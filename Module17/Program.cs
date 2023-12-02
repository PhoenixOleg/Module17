using System.Security.Principal;

namespace Module17
{
    internal class Program
    {
        static void Main()
        {
            GeneralAccount generalAccount = new(999); //Открыли обычный счет и положили 999 денег
            
            Calculator.CalculateInterest(generalAccount);
            generalAccount.DisplayInterest();

            generalAccount.Balance = 1000; //Доложили денег на счет
            Calculator.CalculateInterest(generalAccount);
            generalAccount.DisplayInterest();

            SalaryAccount salaryAccount = new()
            {
                Balance = 1000 //положили 1000 денег
            }; //Открыли открыли зарплатный счет 

            Calculator.CalculateInterest(salaryAccount);
            salaryAccount.DisplayInterest();

            Console.ReadKey();
        }
    }
}