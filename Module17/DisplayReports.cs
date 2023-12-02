using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17
{
    /// <summary>
    /// Статический класс отображения отчетов по счету
    /// </summary>
    public static class DisplayReports
    {
        public static void DisplayInterest(IAccount account)
        {
            Console.WriteLine($@"Ставка счета ""{account.Type}"" при балансе равном {account.Balance} составляет {account.Interest}");
        }
    }
}
