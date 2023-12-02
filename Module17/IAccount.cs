using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17
{
    /// <summary>
    /// Интерфейс обязательных полей класса Account
    /// </summary>
    public interface IAccount
    {
        public string Type { get; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; }
    }
}
