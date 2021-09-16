using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Payment //оплаты абонентов
    {
        public int Id { get; set; }
        public DateTime SumPMinusDate { get; set; } // дата оплаты абонента
        public float SumMinus{ get; set; } // сумма оплаты абонента
        public int SubscriberId { get; set; }
        public string Comments { get; set; } //коментарии
        public virtual Subscriber Subscriber { get; set; }
    }
}
