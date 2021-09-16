using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class DomofonSystem
    {
        public int Id { get; set; }
        public string DomofonSystemType { get; set; } //тип домофонной системы
        public string Comments { get; set; } // примечание
    }
}
