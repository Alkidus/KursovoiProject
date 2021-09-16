using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class DomofonKey
    {
        public int Id { get; set; }
        public string DomofonKeyType { get; set; } //тип домофонного ключа
        public string DomofonKeyCode { get; set; } //код домофонного ключа
    }
}
