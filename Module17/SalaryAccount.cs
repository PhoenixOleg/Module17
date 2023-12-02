﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Module17
{
    public class SalaryAccount : IAccount, IRate
    {
        private double _interest;
        private string _type = "Зарплатный";

        // тип учетной записи
        public string Type { get; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest
        {
            get { return _interest; }
        }

        public SalaryAccount()
        {
            Type = _type;
        }

        public SalaryAccount(double balance)
        {
            Type = _type;
            Balance = balance;
        }

        public void CalculateInterest()
        {
            // расчет процентной ставки зарплатного аккаунта по правилам банка
            _interest = Balance * 0.5;
        }

        public void DisplayInterest()
        {
            DisplayReports.DisplayInterest(this);
        }
    }
}
