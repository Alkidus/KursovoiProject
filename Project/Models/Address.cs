using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Address//адрес
    {
        public int Id { get; set; }
        public string City { get; set; }//город
        public string Street { get; set; }//улица
        public int House { get; set; }//№ дома
        public string Corpus { get; set; }//№ корпуса
        public int Entrance { get; set; } //номер подезда в доме
        public string ContractNumb { get; set; } //номер договора
        public DateTime ContractDate { get; set; } //дата заключения договора на монтаж
        public int FlatCount { get; set; } //общее количество квартир в поъезде
        public int DoorsCount { get; set; } //общее количество дверей в поъезде
        public int DomofonSystemId { get; set; } //тип домофонной системы
        public int DomofonKeyId { get; set; }//тип или код ключа

    }
}
