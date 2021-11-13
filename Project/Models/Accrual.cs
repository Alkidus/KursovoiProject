using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Accrual //начисление абонплаты
    {
        public Accrual()
        {
            Subscribers = new HashSet<Subscriber>();
        }
        public int Id { get; set; }
        public DateTime SumPlusDate { get; set; } //дата начисления абонплаты
        public decimal SumPlus { get; set; } //сумма начисленной абонплаты
        public string Comments { get; set; } //коментарии
        public virtual ICollection<Subscriber> Subscribers { get; set; }
    }
}
