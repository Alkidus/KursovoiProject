using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Company//домофонная компания
    {
        public int Id { get; set; }
        public string Name { get; set; } //название      
        public string Address { get; set; } //адрес
        public string Phone { get; set; } //тедефон
        public string Account { get; set; } //расчетный счет в банке
        public string Code { get; set; } //код ЕДРПОУ
        public string BankCode { get; set; } // МФО банка
    }
}
