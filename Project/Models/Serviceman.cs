using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Serviceman //мастера по ремонту домофонной системы
    {
        public int Id { get; set; }
        public string Name { get; set; } //имя
        public string Surname { get; set; } //фамилия
        public string Phone { get; set; } //теелфон
    }
}
