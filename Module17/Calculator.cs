﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Module17
{
    /// <summary>
    /// Класс калькуляций по счету
    /// </summary>
    public static class Calculator
    {        
        // Метод для расчета процентной ставки
        public static void CalculateInterest(IRate account)
        {
            account.CalculateInterest();
        }
    }
}
