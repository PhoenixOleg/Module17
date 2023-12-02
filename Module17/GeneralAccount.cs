using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Module17
{
    /// <summary>
    /// Класс обычного счета
    /// </summary>
    public class GeneralAccount : IAccount, IRate
    {
        private double _interest;
        private string _type = "Обычный"; //Тип счета менять только здесь

        // тип учетной записи
        public string Type { get; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest 
        { 
            get { return _interest; }
        }

        public GeneralAccount() //Инициализатор по умолчанию добавлен для совместимости с исходными вызовами (чтобы после рефакторинга остальной код не перелопачивать)
        {
            Type = _type;
        }

        public GeneralAccount(double balance)
        {
            Type = _type;
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

        public void DisplayInterest() //Отображение отчета по ставке
        {
            DisplayReports.DisplayInterest(this);
        }
    }
}
