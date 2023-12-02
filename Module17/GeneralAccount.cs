using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Module17
{
    public class GeneralAccount : IRate
    {
        private double _interest;

        // тип учетной записи
        public string Type { get; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest 
        { 
            get { return _interest; }
        }

        public GeneralAccount()
        {
            Type = "Обычный";
        }

        public GeneralAccount(double balance)
        {
            Type = "Обычный";
            Balance = balance;
        }

        public void CalculateInterest()
        {
            // расчет процентной ставки обычного аккаунта по правилам банка
            _interest = Balance * 0.4;
            
            if (Balance < 1000)
                _interest -= Balance * 0.2;

            if (Balance >= 1000)
                _interest -= Balance * 0.4;
        }
    }
}
