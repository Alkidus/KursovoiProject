using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Subscriber //абоненты
    {
        public Subscriber()
        {
            Payments = new List<Payment>();
            Accruals = new List<Accrual>();
            RepairRequests = new List<RepairRequest>();

        }
        public int Id { get; set; }
        public string Name { get; set; } //имя
        public string Surname { get; set; } //фамилия
        public string Phone { get; set; } //телефон
        public int Flat { get; set; } //номер квартиры
        public string ContractNumb { get; set; } //номер договора
        public DateTime ContractDate { get; set; } //дата заключения договора
        public string Code { get; set; } //индивидуальный код абонента
        public int AdressId { get; set; } //адресс
        public int DomofonHandsetId { get; set; } //тип трубки
        public int DomofonKeyId { get; set; } //тип ключа
        public Nullable<int> PaymentId { get; set; } //оплаты
        public Nullable<int> AccrualId { get; set; } //начисления
        public string Comments { get; set; } //коментарии
        public Nullable<int> RepairRequestId { get; set; } //заявки
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Accrual> Accruals { get; set; }
        public virtual ICollection<RepairRequest> RepairRequests { get; set; }
    }
}
