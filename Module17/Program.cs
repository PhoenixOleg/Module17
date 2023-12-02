namespace Module17
{
    internal class Program
    {
        static void Main()
        {
            Account account = new();
            account.Balance = 999;
            account.Type = "Обычный";

            Calculator.CalculateInterest(account);
            Console.WriteLine($@"Ставка счета ""{account.Type}"" при балансе равном {account.Balance} составляет {account.Interest}");

            account.Balance = 1000;
            account.Type = "Обычный";

            Calculator.CalculateInterest(account);
            Console.WriteLine($@"Ставка счета ""{account.Type}"" при балансе равном {account.Balance} составляет {account.Interest}");

            account.Balance = 1000;
            account.Type = "Зарплатный";

            Calculator.CalculateInterest(account);
            Console.WriteLine($@"Ставка счета ""{account.Type}"" при балансе равном {account.Balance} составляет {account.Interest}");

            Console.ReadKey();
        }
    }
}