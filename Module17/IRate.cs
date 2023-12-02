using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17
{
    /// <summary>
    /// Интерфейс расчета процентной ставки
    /// </summary>
    public interface IRate
    {
        public void CalculateInterest();
    }
}
