using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Project.Models;
using Project.Controller;
using Project.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data.Entity;
using System.Diagnostics;

namespace Project
{
    public partial class Form1 : Form
    {
        public string activeTable = "";//переменная для определения выбранной таблицы
        public System.Drawing.Font font = new System.Drawing.Font("Comic Sans MS", 12);//шрифт в dataGridView по умолчанию
        public Color color = Color.Black;//цвет текста в dataGridView по умолчанию
        public int idAdress = 0;//переменная для хранения айдишника выбранного адреса
        public Form1()
        {
            InitializeComponent();
            Text = "PROJECT_DOMOFON";
            this.BackColor = Color.Aquamarine;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            payments_btn.Visible = false; //скрываем кнопку "Оплаты"
            Back_btn.Visible = false; //скрываем кнопку "Назад"
            ChooseSubs_btn.Enabled = false; //деактивируем кнопку "Выбрать абонента"
            //using (DomofonContext db = new DomofonContext())
            //{
            //    db.Companies.Add(
            //        new Company
            //        {
            //            Name = "К.С-Инвест",
            //            Address = "г.Чернигов, ул. Родимцева 14",//адрес
            //            Phone = "+38 (0462) 614-681",//тедефон
            //            Account = "UA133052990000026008006300527",//расчетный счет в банке
            //            Code = "33660167",//код ЕДРПОУ
            //            BankCode = "305299"// МФО банка
            //        }
            //    );
            //    db.Servicemen.Add(new Serviceman { Name = "Петя", Surname = "Павленко", Phone = "0937033817" });
            //    db.Servicemen.Add(new Serviceman { Name = "Кирилл", Surname = "Павленко", Phone = "0934163083" });
            //    db.DomofonHandsets.Add(
            //        new DomofonHandset
            //        {
            //            DomofonHandsetType = "undefined"
            //        });
            //    db.DomofonHandsets.Add(
            //        new DomofonHandset
            //        {
            //            DomofonHandsetType = "ТАП-02"
            //        });
            //    db.DomofonHandsets.Add(
            //        new DomofonHandset
            //        {
            //            DomofonHandsetType = "УКП-7"
            //        });
            //    db.DomofonHandsets.Add(
            //        new DomofonHandset
            //        {
            //            DomofonHandsetType = "УКП-12"
            //        });
            //    db.DomofonHandsets.Add(
            //        new DomofonHandset
            //        {
            //            DomofonHandsetType = "УКП-12М"
            //        });
            //    db.DomofonHandsets.Add(
            //        new DomofonHandset
            //        {
            //            DomofonHandsetType = "SmartEl"
            //        });
            //    db.DomofonHandsets.Add(
            //        new DomofonHandset
            //        {
            //            DomofonHandsetType = "ВИДЕО"
            //        });
            //    db.DomofonKeys.Add(
            //        new DomofonKey
            //        {
            //            DomofonKeyType = "undefined"
            //        });
            //    db.DomofonKeys.Add(
            //        new DomofonKey
            //        {
            //            DomofonKeyType = "АДК"
            //        });
            //    db.DomofonKeys.Add(
            //        new DomofonKey
            //        {
            //            DomofonKeyType = "Беркут ТМ"
            //        });
            //    db.DomofonKeys.Add(
            //        new DomofonKey
            //        {
            //            DomofonKeyType = "Беркут RC - 310"
            //        });
            //    db.DomofonKeys.Add(
            //        new DomofonKey
            //        {
            //            DomofonKeyType = "Беркут RC - T470"
            //        });
            //    db.DomofonKeys.Add(
            //        new DomofonKey
            //        {
            //            DomofonKeyType = "Беркут RC - 2K4"
            //        });
            //    db.DomofonKeys.Add(
            //        new DomofonKey
            //        {
            //            DomofonKeyType = "Беркут RC - T6K8"
            //        });
            //    db.DomofonKeys.Add(
            //        new DomofonKey
            //        {
            //            DomofonKeyType = "Vizit RF-2.1"
            //        });
            //    db.DomofonKeys.Add(
            //        new DomofonKey
            //        {
            //            DomofonKeyType = "Cyfral Dallas"
            //        });
            //    db.DomofonSystems.Add(
            //        new DomofonSystem
            //        {
            //            DomofonSystemType = "undefined"
            //        });
            //    db.DomofonSystems.Add(
            //        new DomofonSystem
            //        {
            //            DomofonSystemType = "АДК"
            //        });
            //    db.DomofonSystems.Add(
            //        new DomofonSystem
            //        {
            //            DomofonSystemType = "Беркут"
            //        });
            //    db.DomofonSystems.Add(
            //    new DomofonSystem
            //    {
            //        DomofonSystemType = "Vizit"
            //    });
            //    db.DomofonSystems.Add(
            //    new DomofonSystem
            //    {
            //        DomofonSystemType = "Cyfral"
            //    });
            //    db.DomofonSystems.Add(
            //    new DomofonSystem
            //    {
            //        DomofonSystemType = "Беркут SmartEl"
            //    });
            //    db.Addresses.Add(
            //        new Address
            //        {
            //            City = "Чернигов",
            //            Street = "Ивана Мазепы",
            //            House = 33,
            //            Entrance = 4,
            //            ContractNumb = "697",
            //            ContractDate = new DateTime(2010, 10, 12),
            //            FlatCount = 15,
            //            DoorsCount = 1,
            //            DomofonSystemId = 3,
            //            DomofonKeyId = 7
            //        });
            //    db.Addresses.Add(
            //        new Address
            //        {
            //            City = "Чернигов",
            //            Street = "Мстиславского",
            //            House = 34,
            //            Entrance = 1,
            //            ContractNumb = "481",
            //            ContractDate = new DateTime(2008, 05, 11),
            //            FlatCount = 36,
            //            DoorsCount = 1,
            //            DomofonSystemId = 2,
            //            DomofonKeyId = 4
            //        });
            //    db.Addresses.Add(
            //        new Address
            //        {
            //            City = "Чернигов",
            //            Street = "Попудренко",
            //            House = 12,
            //            Corpus = "Б",
            //            Entrance = 3,
            //            ContractNumb = "218",
            //            ContractDate = new DateTime(2012, 02, 22),
            //            FlatCount = 15,
            //            DoorsCount = 1,
            //            DomofonSystemId = 4,
            //            DomofonKeyId = 8
            //        });
            //    db.Subscribers.Add(
            //        new Subscriber
            //        {
            //            Name = "Тамара",
            //            Surname = "Мельникова",
            //            Phone = "+380683871920",
            //            Flat = 57,
            //            ContractNumb = "221",
            //            ContractDate = new DateTime(2010, 10, 21),
            //            Code = "500697057",
            //            AddressId = 1,
            //            DomofonHandsetId = 3,
            //            DomofonKeyId = 7,
            //            Comments = "Хочет поменять на видеодомофон"
            //        });
            //    db.Subscribers.Add(
            //        new Subscriber
            //        {
            //            Name = "Антонина",
            //            Surname = "Вивденко",
            //            Phone = "+380504652012",
            //            Flat = 56,
            //            ContractNumb = "220",
            //            ContractDate = new DateTime(2010, 10, 20),
            //            Code = "500697056",
            //            AddressId = 1,
            //            DomofonHandsetId = 4,
            //            DomofonKeyId = 7
            //        });
            //    db.Subscribers.Add(
            //        new Subscriber
            //        {
            //            Name = "Сергей",
            //            Surname = "Шурубенко",
            //            Phone = "+380502216025",
            //            Flat = 59,
            //            ContractNumb = "223",
            //            ContractDate = new DateTime(2015, 11, 11),
            //            Code = "500697059",
            //            AddressId = 1,
            //            DomofonHandsetId = 5,
            //            DomofonKeyId = 7
            //        });
            //    db.Subscribers.Add(
            //        new Subscriber
            //        {
            //            Name = "Андрей",
            //            Surname = "Древа",
            //            Phone = "+380685528956",
            //            Flat = 5,
            //            ContractNumb = "17",
            //            ContractDate = new DateTime(2012, 12, 12),
            //            Code = "500481005",
            //            AddressId = 2,
            //            DomofonHandsetId = 1,
            //            DomofonKeyId = 4
            //        });
            //    db.Subscribers.Add(
            //        new Subscriber
            //        {
            //            Name = "Владимир",
            //            Surname = "Королёв",
            //            Phone = "+38972689541",
            //            Flat = 13,
            //            ContractNumb = "23",
            //            ContractDate = new DateTime(2014, 02, 16),
            //            Code = "500481013",
            //            AddressId = 2,
            //            DomofonHandsetId = 2,
            //            DomofonKeyId = 4
            //        });
            //    db.Subscribers.Add(
            //        new Subscriber
            //        {
            //            Name = "Марина",
            //            Surname = "Огурец",
            //            Phone = "+380502020100",
            //            Flat = 40,
            //            ContractNumb = "20",
            //            ContractDate = new DateTime(2017, 10, 20),
            //            Code = "500218040",
            //            AddressId = 3,
            //            DomofonHandsetId = 3,
            //            DomofonKeyId = 8
            //        });
            //    db.Accruals.Add(
            //        new Accrual
            //        {
            //            SumPlusDate = new DateTime(2020, 1, 1),
            //            SumPlus = 45,
            //            Comments = "Первый квартал 2020 года"

            //        });
            //    db.Accruals.Add(
            //        new Accrual
            //        {
            //            SumPlusDate = new DateTime(2020, 4, 1),
            //            SumPlus = 45,
            //            Comments = "Второй квартал"
            //        });
            //    db.Accruals.Add(
            //        new Accrual
            //        {
            //            SumPlusDate = new DateTime(2020, 7, 1),
            //            SumPlus = 45,
            //            Comments = "третий"
            //        });
            //    db.Accruals.Add(
            //        new Accrual
            //        {
            //            SumPlusDate = new DateTime(2020, 10, 1),
            //            SumPlus = 45,
            //            Comments = "IV cvartal"
            //        });
            //    db.Accruals.Add(
            //        new Accrual
            //        {
            //            SumPlusDate = new DateTime(2021, 1, 1),
            //            SumPlus = 51
            //        });
            //    db.Accruals.Add(
            //        new Accrual
            //        {
            //            SumPlusDate = new DateTime(2021, 4, 1),
            //            SumPlus = 51
            //        });
            //    db.Accruals.Add(
            //        new Accrual
            //        {
            //            SumPlusDate = new DateTime(2021, 7, 1),
            //            SumPlus = 51
            //        });
            //    db.Accruals.Add(
            //        new Accrual
            //        {
            //            SumPlusDate = new DateTime(2021, 10, 1),
            //            SumPlus = 51
            //        });


            //    db.SaveChanges();
            //}
            GetAllCompanies();
            activeTable = "company";
        }
        private void GetAllCompanies()//Получение списка всех компаний
        {
            using (DomofonContext db = new DomofonContext())
            {
                var comp = db.Companies.ToList();
                dataGridView1.Columns.Add("col0", "ID");
                dataGridView1.Columns.Add("col1", "Название");
                dataGridView1.Columns.Add("col2", "Адрес");
                dataGridView1.Columns.Add("col3", "Телефон");
                dataGridView1.Columns.Add("col4", "Счёт");
                dataGridView1.Columns.Add("col5", "код ЕДРПОУ");
                dataGridView1.Columns.Add("col6", "МФО");

                foreach (var item in comp)
                {
                    dataGridView1.Rows.Add(item.Id, item.Name, item.Address, item.Phone, item.Account, item.Code, item.BankCode);
                }
            }
            ChangeFontAndColor();//применяем выбранный пользователем стиль шрифта и цвет
            payments_btn.Visible = false; //скрываем кнопку "Оплаты"
            Back_btn.Visible = false; //скрываем кнопку "Назад"
            ChooseSubs_btn.Enabled = false; //деактивируем кнопку "Выбрать абонента"
            label1.Text = "Операции с компанией:";
        }

        private void GetAllAdresses()//получение списка всех адресов
        {
            using (DomofonContext db = new DomofonContext())
            {
                var adress = db.Addresses.ToList();
                dataGridView1.Columns.Add("col0", "ID");
                dataGridView1.Columns.Add("col1", "Город");
                dataGridView1.Columns.Add("col2", "Улица");
                dataGridView1.Columns.Add("col3", "Дом");
                dataGridView1.Columns.Add("col4", "Корпус");
                dataGridView1.Columns.Add("col5", "Подъезд");
                dataGridView1.Columns.Add("col6", "№ договора");
                dataGridView1.Columns.Add("col7", "Дата договора");
                dataGridView1.Columns.Add("col8", "Кол-во квартир");
                dataGridView1.Columns.Add("col9", "Кол-во дверей");
                dataGridView1.Columns.Add("col10", "Тип домофона");
                dataGridView1.Columns.Add("col11", "Тип ключей");

                foreach (var item in adress)
                {
                    dataGridView1.Rows.Add(item.Id, item.City, item.Street, item.House,
                        item.Corpus, item.Entrance, item.ContractNumb, item.ContractDate.ToShortDateString(),
                        item.FlatCount, item.DoorsCount,
                        db.DomofonSystems.FirstOrDefault(el => el.Id == item.DomofonSystemId).DomofonSystemType,
                        db.DomofonKeys.FirstOrDefault(el => el.Id == item.DomofonKeyId).DomofonKeyType);
                }
            }
            ChangeFontAndColor();//применяем выбранный пользователем стиль шрифта и цвет
            payments_btn.Visible = true; //отображаем кнопку "Оплаты"
            Back_btn.Visible = false; //скрываем кнопку "Назад"
            ChooseSubs_btn.Enabled = true; //активируем кнопку "Выбрать абонента"
            label1.Text = "Операции с адресами:";
        }
        private void Adress_btn_Click(object sender, EventArgs e)//кнопка "СПИСОК АДРЕСОВ"
        {
            ClearTable();//очитска таблицы
            GetAllAdresses();//получаем все адреса
            activeTable = "adress";//активируем таблицу адреса
        }

        private void Keys_btn_Click(object sender, EventArgs e)//кнопка "КЛЮЧИ"
        {
            ClearTable();
            GetAllKeys();
            activeTable = "key";
        }

        private void GetAllKeys()//получаем список всех ключей
        {
            using (DomofonContext db = new DomofonContext())
            {
                var keys = db.DomofonKeys.ToList();
                dataGridView1.Columns.Add("col0", "ID");
                dataGridView1.Columns.Add("col1", "Тип ключа");
                dataGridView1.Columns.Add("col2", "Комментарии");

                foreach (var item in keys)
                {
                    dataGridView1.Rows.Add(item.Id, item.DomofonKeyType, item.Comments);
                }
            }
            ChangeFontAndColor();
            payments_btn.Visible = false; //скрываем кнопку "Оплаты"
            Back_btn.Visible = false; //скрываем кнопку "Назад"
            ChooseSubs_btn.Enabled = false; //деактивируем кнопку "Выбрать абонента"
            label1.Text = "Операции с ключами:";
        }

        private void HandSet_btn_Click(object sender, EventArgs e)
        {
            ClearTable();
            GetAllHandSets();
            activeTable = "handset";
        }

        private void GetAllHandSets()
        {
            using (DomofonContext db = new DomofonContext())
            {
                var handsets = db.DomofonHandsets.ToList();
                dataGridView1.Columns.Add("col0", "ID");
                dataGridView1.Columns.Add("col1", "Тип трубки");
                dataGridView1.Columns.Add("col2", "Комментарии");

                foreach (var item in handsets)
                {
                    dataGridView1.Rows.Add(item.Id, item.DomofonHandsetType, item.Comments);
                }
            }
            ChangeFontAndColor();
            payments_btn.Visible = false; //скрываем кнопку "Оплаты"
            Back_btn.Visible = false; //скрываем кнопку "Назад"
            ChooseSubs_btn.Enabled = false; //деактивируем кнопку "Выбрать абонента"
            label1.Text = "Операции с трубками:";
        }

        private void Domofons_btn_Click(object sender, EventArgs e)
        {
            ClearTable();
            GetAllDomofonSystems();
            activeTable = "domofon";
        }

        private void GetAllDomofonSystems()
        {
            using (DomofonContext db = new DomofonContext())
            {
                var domofonsystems = db.DomofonSystems.ToList();
                dataGridView1.Columns.Add("col0", "ID");
                dataGridView1.Columns.Add("col1", "Тип домофона");
                dataGridView1.Columns.Add("col2", "Комментарии");

                foreach (var item in domofonsystems)
                {
                    dataGridView1.Rows.Add(item.Id, item.DomofonSystemType, item.Comments);
                }
            }
            ChangeFontAndColor();
            payments_btn.Visible = false; //скрываем кнопку "Оплаты"
            Back_btn.Visible = false; //скрываем кнопку "Назад"
            ChooseSubs_btn.Enabled = false; //деактивируем кнопку "Выбрать абонента"
            label1.Text = "Операции с домофонами:";
        }

        private void addServiсemanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearTable();
            GetAllServiсeman();
            activeTable = "serviceman";
        }

        private void GetAllServiсeman()
        {
            using (DomofonContext db = new DomofonContext())
            {
                var servicemen = db.Servicemen.ToList();
                dataGridView1.Columns.Add("col0", "ID");
                dataGridView1.Columns.Add("col1", "Имя");
                dataGridView1.Columns.Add("col2", "Фамилия");
                dataGridView1.Columns.Add("col3", "Телефон");

                foreach (var item in servicemen)
                {
                    dataGridView1.Rows.Add(item.Id, item.Name, item.Surname, item.Phone);
                }
            }
            ChangeFontAndColor();
            payments_btn.Visible = false; //скрываем кнопку "Оплаты"
            Back_btn.Visible = false; //скрываем кнопку "Назад"
            ChooseSubs_btn.Enabled = false; //деактивируем кнопку "Выбрать абонента"
            label1.Text = "Операции с мастерами:";
        }
        private void GetAllAccruals()//выводим таблицу всех начислений
        {
            using (DomofonContext db = new DomofonContext())
            {
                var accrual = db.Accruals.ToList();
                dataGridView1.Columns.Add("col0", "ID");
                dataGridView1.Columns.Add("col1", "Дата начисления");
                dataGridView1.Columns.Add("col2", "Сумма");
                dataGridView1.Columns.Add("col3", "Комментарии");

                foreach (var item in accrual)
                {
                    dataGridView1.Rows.Add(item.Id, item.SumPlusDate.ToShortDateString(), item.SumPlus, item.Comments);
                }
            }
            ChangeFontAndColor();
            payments_btn.Visible = false; //скрываем кнопку "Оплаты"
            Back_btn.Visible = false; //скрываем кнопку "Назад"
            ChooseSubs_btn.Enabled = false; //деактивируем кнопку "Выбрать абонента"
        }
        private void chooseCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearTable();
            GetAllCompanies();
            ChangeFontAndColor();
            activeTable = "company";
        }
        private void ClearTable()//функция очистки dataGridView
        {
            this.dataGridView1.Rows.Clear();  // удаление всех строк
            int count = this.dataGridView1.Columns.Count;
            for (int i = 0; i < count; i++)     // цикл удаления всех столбцов
            {
                this.dataGridView1.Columns.RemoveAt(0);
            }

        }

        private void ChooseSubs_btn_Click(object sender, EventArgs e)
        {
            if (activeTable != "adress")
                return;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                idAdress = id;
            }
            GetAllSubscribersByAdress(idAdress);
            ChangeFontAndColor();
            activeTable = "subscriber";

        }

        private void GetAllSubscribersByAdress(int ID)
        {
            payments_btn.Visible = true; //отобразить кнопку "Оплаты"
            Back_btn.Visible = true; //отобразить кнопку "Назад"
            ChooseSubs_btn.Enabled = false; //деактивируем кнопку "Выбрать абонента"
            ClearTable();
            using (DomofonContext db = new DomofonContext())
            {
                var subscribers = from sub in db.Subscribers
                                  where sub.AddressId == ID
                                  select sub;
                var subscriberList = subscribers.ToList();
                dataGridView1.Columns.Add("col0", "ID");
                dataGridView1.Columns.Add("col1", "Адрес");
                dataGridView1.Columns.Add("col2", "Квартира");
                dataGridView1.Columns.Add("col3", "Имя");
                dataGridView1.Columns.Add("col4", "Фамилия");
                dataGridView1.Columns.Add("col5", "Телефон");
                dataGridView1.Columns.Add("col6", "№ договора");
                dataGridView1.Columns.Add("col7", "Дата договора");
                dataGridView1.Columns.Add("col8", "ID код");
                dataGridView1.Columns.Add("col9", "Трубка");
                dataGridView1.Columns.Add("col10", "Ключ");
                dataGridView1.Columns.Add("col11", "Комментарии");

                foreach (var item in subscriberList)
                {
                    dataGridView1.Rows.Add(item.Id, db.Addresses.FirstOrDefault(el => el.Id == ID).Street + " № "
                        + db.Addresses.FirstOrDefault(el => el.Id == ID).House
                        + "к. " + db.Addresses.FirstOrDefault(el => el.Id == ID).Corpus
                        + " п. " + db.Addresses.FirstOrDefault(el => el.Id == ID).Entrance,
                        item.Flat, item.Name, item.Surname, item.Phone, item.ContractNumb, item.ContractDate.ToShortDateString(),
                        item.Code, db.DomofonHandsets.FirstOrDefault(el => el.Id == item.DomofonHandsetId).DomofonHandsetType,
                        db.DomofonKeys.FirstOrDefault(el => el.Id == item.DomofonKeyId).DomofonKeyType, item.Comments);
                }
            }
            label1.Text = "Операции с абонентами:";
        }
        private void Repair_btn_Click(object sender, EventArgs e)
        {
            ClearTable();
            GetAllRepairs();
            activeTable = "repair";
        }

        private void GetAllRepairs()
        {
            using (DomofonContext db = new DomofonContext())
            {
                var repairs = db.RepairRequests.ToList();
                dataGridView1.Columns.Add("col0", "ID");
                dataGridView1.Columns.Add("col1", "Дата заявки");
                dataGridView1.Columns.Add("col2", "Адрес");
                dataGridView1.Columns.Add("col3", "Квартира");
                dataGridView1.Columns.Add("col4", "Заявленная неисправность");
                dataGridView1.Columns.Add("col5", "Дата выполнения");
                dataGridView1.Columns.Add("col6", "Что ремонтировалось");
                dataGridView1.Columns.Add("col7", "Статус");
                dataGridView1.Columns.Add("col8", "Абонент");
                dataGridView1.Columns.Add("col9", "Комментарии");

                foreach (var item in repairs)//баг при добавлении пустой заявки
                {
                    dataGridView1.Rows.Add(item.Id, item.DateRepairBegin.ToShortDateString(), db.Addresses.FirstOrDefault(el => el.Id == item.AddressId).Street + " № "
                        + db.Addresses.FirstOrDefault(el => el.Id == item.AddressId).House
                        + "к. " + db.Addresses.FirstOrDefault(el => el.Id == item.AddressId).Corpus
                        + " п. " + db.Addresses.FirstOrDefault(el => el.Id == item.AddressId).Entrance, item.Flat,
                        item.DescriptionFromSub, item.DateRepairEnd.ToShortDateString(), item.DescriptionFromServ,
                        item.Status, item.SubscriberId, item.Comments);
                }
            }
            ChangeFontAndColor();
            payments_btn.Visible = false; //скрываем кнопку "Оплаты"
            Back_btn.Visible = false; //скрываем кнопку "Назад"
            ChooseSubs_btn.Enabled = false; //деактивируем кнопку "Выбрать абонента"
            label1.Text = "Операции с заявками:";
        }
        private void CalculatePaymentForNewSubscriber(Subscriber subscriber) //высчитываем сумму начисления абонплаты для нового абонента
        {
            using (DomofonContext db = new DomofonContext())
            {
                Accrual lastAccrual = new Accrual();
                int? intIdt = db.Accruals.Max(accrual => (int?)accrual.Id);//ищем последнее начисление с максимальным id
                if (intIdt == null)
                {
                    MessageBox.Show("Нет ни одного начисления! Сперва начислите абонплату!", "ERROR");
                    return;
                }
                lastAccrual = db.Accruals.Find(intIdt);
                int numberDeysInAccrual = 0; //количество дней в последнем начисленном квартале
                decimal totalAccrual = 0; //Общая сумма всех начисленй
                decimal sumPerDay = 0; //сумма гривен/вдень
                int daysToEnd = 0; //количество дней от даты добавления нового абонента и до конца квартала
                decimal sumToEnd = 0; //сумма долга абонента
                decimal paymentSum = 0; // итоговая сумма фиктивной оплаты

                var allAccruals = from accruals in db.Accruals
                                  select accruals;
                foreach (var el in allAccruals)
                    totalAccrual += el.SumPlus;
                DateTime addDate = subscriber.ContractDate;// createDate; ; //дата создания абонента
                DateTime startAccrual = lastAccrual.SumPlusDate; //дата начала квартала
                DateTime endAccrual = startAccrual.AddMonths(3); //дата окончания квартала

                numberDeysInAccrual = DateTime.DaysInMonth(startAccrual.Year, startAccrual.Month) + //количество дней в квартале
                    DateTime.DaysInMonth(startAccrual.Year, startAccrual.Month + 1) +
                    DateTime.DaysInMonth(startAccrual.Year, startAccrual.Month + 2);

                daysToEnd = (endAccrual.Date - addDate.Date).Days; //количество дней от даты создания абонента и до конца квартала

                sumPerDay = lastAccrual.SumPlus / numberDeysInAccrual;
                sumPerDay = Decimal.Round(sumPerDay, 2); //округляем до двух знаков после запятой

                sumToEnd = sumPerDay * daysToEnd;
                sumToEnd = Decimal.Round(sumToEnd, 2); //округляем до двух знаков после запятой

                paymentSum = totalAccrual - sumToEnd;
                paymentSum = Decimal.Round(paymentSum, 2); //округляем до двух знаков после запятой

                Payment payment = new Payment();
                payment.SubscriberId = subscriber.Id;
                payment.SumMinusDate = subscriber.ContractDate; //createDate;
                payment.SumMinus = paymentSum;
                db.Payments.Add(payment);
                db.SaveChanges();
            }
        }
        private void ADD_btn_Click(object sender, EventArgs e)
        {
            DialogResult result;
            switch (activeTable)
            {
                case "company":
                    CompanyForm companyForm = new CompanyForm();
                    result = companyForm.ShowDialog(this);
                    if (result == DialogResult.Cancel)
                        return;
                    using (DomofonContext db = new DomofonContext())
                    {
                        Company company = new Company();
                        company.Name = companyForm.textBox1.Text;
                        company.Address = companyForm.textBox2.Text;
                        company.Phone = companyForm.textBox3.Text;
                        company.Account = companyForm.textBox4.Text;
                        company.Code = companyForm.textBox5.Text;
                        company.BankCode = companyForm.textBox6.Text;
                        db.Companies.Add(company);
                        db.SaveChanges();
                        ClearTable();
                        GetAllCompanies();
                    }
                    break;
                case "serviceman":
                    ServicemanForm servicemanForm = new ServicemanForm();
                    result = servicemanForm.ShowDialog(this);
                    if (result == DialogResult.Cancel)
                        return;
                    using (DomofonContext db = new DomofonContext())
                    {
                        Serviceman serviceman = new Serviceman();
                        serviceman.Name = servicemanForm.textBox1.Text;
                        serviceman.Surname = servicemanForm.textBox2.Text;
                        serviceman.Phone = servicemanForm.textBox3.Text;
                        db.Servicemen.Add(serviceman);
                        db.SaveChanges();
                        ClearTable();
                        GetAllServiсeman();
                    }
                    break;
                case "subscriber":
                    SubscriberForm subscriberform = new SubscriberForm(idAdress);
                    result = subscriberform.ShowDialog(this);
                    if (result == DialogResult.Cancel)
                        return;
                    using (DomofonContext db = new DomofonContext())
                    {
                        Subscriber subscriber = new Subscriber();
                        subscriber.Name = subscriberform.textBox1.Text;
                        subscriber.Surname = subscriberform.textBox2.Text;
                        subscriber.Phone = subscriberform.textBox3.Text;
                        subscriber.Flat = (int)subscriberform.numericUpDown1.Value;
                        subscriber.ContractNumb = subscriberform.textBox4.Text;
                        subscriber.ContractDate = subscriberform.dateTimePicker1.Value;
                        subscriber.Code = subscriberform.textBox5.Text;
                        subscriber.Comments = subscriberform.textBox6.Text;
                            var domofonAdresstID = db.Addresses.FirstOrDefault(el => el.Street + " дом № " + el.House + " корпус " + el.Corpus + " подъезд № " + el.Entrance == subscriberform.comboBox1.SelectedItem.ToString());
                            if (domofonAdresstID != null)
                            {
                                subscriber.AddressId = domofonAdresstID.Id;
                            }
                        if (subscriberform.comboBox2.SelectedIndex != -1)
                        {
                            var domofonHandsetID = db.DomofonHandsets.FirstOrDefault(el => el.DomofonHandsetType == subscriberform.comboBox2.SelectedItem.ToString());
                            subscriber.DomofonHandsetId = domofonHandsetID.Id;
                        }
                        else
                            subscriber.DomofonHandsetId = db.DomofonHandsets.FirstOrDefault().Id;
                        if (subscriberform.comboBox3.SelectedIndex != -1)
                        {
                            var domofonKeyID = db.DomofonKeys.FirstOrDefault(el => el.DomofonKeyType == subscriberform.comboBox3.SelectedItem.ToString());
                            subscriber.DomofonKeyId = domofonKeyID.Id;
                        }
                        else
                            subscriber.DomofonKeyId = db.DomofonKeys.FirstOrDefault().Id;

                        db.Subscribers.Add(subscriber);
                        db.SaveChanges();
                        CalculatePaymentForNewSubscriber(subscriber);
                        db.SaveChanges();
                        ClearTable();
                        GetAllSubscribersByAdress(idAdress);
                    }
                    break;
                case "repair":
                    RepairForm repairForm = new RepairForm();
                    result = repairForm.ShowDialog(this);
                    if (result == DialogResult.Cancel)
                        return;
                    using (DomofonContext db = new DomofonContext())
                    {
                        RepairRequest repair = new RepairRequest();
                        repair.DateRepairBegin = repairForm.dateTimePicker1.Value;
                        repair.AddressId = repairForm.idAddress;
                        repair.Flat = (int)repairForm.numericUpDown1.Value;
                        repair.DescriptionFromSub = repairForm.textBox3.Text;
                        repair.DateRepairEnd = repairForm.dateTimePicker2.Value;
                        repair.DescriptionFromServ = repairForm.textBox4.Text;
                        repair.Status = repairForm.comboBox2.SelectedItem.ToString();
                        repair.SubscriberId = repairForm.subscriderID;
                        repair.Comments = repairForm.textBox5.Text;
                        db.RepairRequests.Add(repair);
                        db.SaveChanges(); 

                        ClearTable();
                        GetAllRepairs();
                    }
                    break;
                case "adress":
                    AddressForm adressform = new AddressForm();
                    result = adressform.ShowDialog(this);
                    if (result == DialogResult.Cancel)
                        return;
                    using (DomofonContext db = new DomofonContext())
                    {
                        Address adress = new Address();
                        adress.City = adressform.textBox1.Text;
                        adress.Street = adressform.textBox2.Text;
                        adress.House = (int)adressform.numericUpDown1.Value;
                        adress.Corpus = adressform.textBox3.Text;
                        adress.Entrance = (int)adressform.numericUpDown2.Value;
                        adress.ContractNumb = adressform.textBox5.Text;
                        adress.ContractDate = adressform.dateTimePicker1.Value;
                        adress.FlatCount = (int)adressform.numericUpDown3.Value;
                        adress.DoorsCount = (int)adressform.numericUpDown4.Value;

                        var domofonSystemID = db.DomofonSystems.FirstOrDefault(el => el.DomofonSystemType == adressform.comboBox1.SelectedItem.ToString());
                        if (domofonSystemID != null)
                        {
                            adress.DomofonSystemId = domofonSystemID.Id;
                        }
                        var domofonKeyID = db.DomofonKeys.FirstOrDefault(el => el.DomofonKeyType == adressform.comboBox2.SelectedItem.ToString());
                        if (domofonKeyID != null)
                        {
                            adress.DomofonKeyId = domofonKeyID.Id;
                        }
                        db.Addresses.Add(adress);
                        db.SaveChanges();
                        ClearTable();
                        GetAllAdresses();
                    }

                    break;
                case "key":
                    Key_Handset_Domofon_Form keyForm = new Key_Handset_Domofon_Form("key");
                    result = keyForm.ShowDialog(this);
                    if (result == DialogResult.Cancel)
                        return;
                    using (DomofonContext db = new DomofonContext())
                    {
                        DomofonKey domofonKey = new DomofonKey();
                        domofonKey.DomofonKeyType = keyForm.textBox1.Text;
                        domofonKey.Comments = keyForm.textBox2.Text;
                        db.DomofonKeys.Add(domofonKey);
                        db.SaveChanges();
                        ClearTable();
                        GetAllKeys();
                    }
                    break;
                case "handset":
                    Key_Handset_Domofon_Form handsetForm = new Key_Handset_Domofon_Form("handset");
                    result = handsetForm.ShowDialog(this);
                    if (result == DialogResult.Cancel)
                        return;
                    using (DomofonContext db = new DomofonContext())
                    {
                        DomofonHandset handset = new DomofonHandset();
                        handset.DomofonHandsetType = handsetForm.textBox1.Text;
                        handset.Comments = handsetForm.textBox2.Text;
                        db.DomofonHandsets.Add(handset);
                        db.SaveChanges();
                        ClearTable();
                        GetAllHandSets();
                    }
                    break;
                case "domofon":
                    Key_Handset_Domofon_Form domofonForm = new Key_Handset_Domofon_Form("domofon");
                    result = domofonForm.ShowDialog(this);
                    if (result == DialogResult.Cancel)
                        return;
                    using (DomofonContext db = new DomofonContext())
                    {
                        DomofonSystem domofon = new DomofonSystem();
                        domofon.DomofonSystemType = domofonForm.textBox1.Text;
                        domofon.Comments = domofonForm.textBox2.Text;
                        db.DomofonSystems.Add(domofon);
                        db.SaveChanges();
                        ClearTable();
                        GetAllDomofonSystems();
                    }
                    break;
                case "payments":
                    int ID = (int)dataGridView1[0, 0].Value;
                    string Adress = dataGridView1[0, 1].Value.ToString();
                    string AdressFull = Adress + " кв. " + dataGridView1[0, 2].Value.ToString();
                    PaymentForm paymentForm = new PaymentForm("payments");
                    paymentForm.textBox1.Text = AdressFull;
                    DialogResult dialogResult = paymentForm.ShowDialog(this);
                    if (dialogResult == DialogResult.Cancel)
                        return;
                    using (DomofonContext db = new DomofonContext())
                    {
                        Payment payment = new Payment();
                        payment.SumMinusDate = paymentForm.dateTimePicker1.Value;
                        payment.SumMinus = paymentForm.numericUpDown1.Value + paymentForm.numericUpDown2.Value / 100;
                        payment.Comments = paymentForm.textBox3.Text;
                        payment.SubscriberId = ID;
                        db.Payments.Add(payment);
                        db.SaveChanges();
                        ClearTable();
                        GetSubscriberPayments(ID, Adress);
                    }
                    ChangeFontAndColor();
                    payments_btn.Visible = false; //скрываем кнопку "Оплаты"
                    Back_btn.Visible = true; //отобразить кнопку "Назад"
                    ChooseSubs_btn.Enabled = false; //деактивируем кнопку "Выбрать абонента"
                    break;
                case "accrual":
                    AddAccrual();
                    GetAllAccruals();
                    break;

            }
        }

        private void CHAGE_btn_Click(object sender, EventArgs e)
        {
            switch (activeTable)
            {
                case "company":
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        int index = dataGridView1.SelectedRows[0].Index;
                        int id = 0;
                        bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                        if (converted == false)
                            return;
                        using (DomofonContext db = new DomofonContext())
                        {
                            Company company = db.Companies.Find(id);
                            CompanyForm companyForm = new CompanyForm();
                            companyForm.textBox1.Text = company.Name;
                            companyForm.textBox2.Text = company.Address;
                            companyForm.textBox3.Text = company.Phone;
                            companyForm.textBox4.Text = company.Account;
                            companyForm.textBox5.Text = company.Code;
                            companyForm.textBox6.Text = company.BankCode;
                            DialogResult result = companyForm.ShowDialog(this);
                            if (result == DialogResult.Cancel)
                                return;
                            company.Name = companyForm.textBox1.Text;
                            company.Address = companyForm.textBox2.Text;
                            company.Phone = companyForm.textBox3.Text;
                            company.Account = companyForm.textBox4.Text;
                            company.Code = companyForm.textBox5.Text;
                            company.BankCode = companyForm.textBox6.Text;
                            db.SaveChanges();
                            ClearTable();
                            GetAllCompanies();
                        }
                    }
                    break;
                case "serviceman":
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        int index = dataGridView1.SelectedRows[0].Index;
                        int id = 0;
                        bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                        if (converted == false)
                            return;
                        using (DomofonContext db = new DomofonContext())
                        {
                            Serviceman serviceman = db.Servicemen.Find(id);
                            ServicemanForm servicemanForm = new ServicemanForm();
                            servicemanForm.textBox1.Text = serviceman.Name;
                            servicemanForm.textBox2.Text = serviceman.Surname;
                            servicemanForm.textBox3.Text = serviceman.Phone;
                            DialogResult result = servicemanForm.ShowDialog(this);

                            if (result == DialogResult.Cancel)
                                return;

                            serviceman.Name = servicemanForm.textBox1.Text;
                            serviceman.Surname = servicemanForm.textBox2.Text;
                            serviceman.Phone = servicemanForm.textBox3.Text;
                            db.SaveChanges();
                            ClearTable();
                            GetAllServiсeman();
                        }
                    }
                    break;
                case "subscriber":
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        int index = dataGridView1.SelectedRows[0].Index;
                        int id = 0;
                        bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                        if (converted == false)
                            return;
                        using (DomofonContext db = new DomofonContext())
                        {
                            Subscriber subscriber = db.Subscribers.Find(id);
                            SubscriberForm subscriberform = new SubscriberForm(idAdress);
                            subscriberform.textBox1.Text = subscriber.Name;
                            subscriberform.textBox2.Text = subscriber.Surname;
                            subscriberform.textBox3.Text = subscriber.Phone;
                            subscriberform.numericUpDown1.Value = subscriber.Flat;
                            subscriberform.textBox4.Text = subscriber.ContractNumb;
                            subscriberform.dateTimePicker1.Value = subscriber.ContractDate;
                            subscriberform.textBox5.Text = subscriber.Code;
                            subscriberform.textBox6.Text = subscriber.Comments;
                            for (int i = 0; i < subscriberform.comboBox1.Items.Count; i++)
                            {
                                var adress = db.Addresses.FirstOrDefault(el => el.Id == subscriber.AddressId);
                                if (subscriberform.comboBox1.Items[i].ToString() == adress.Street + " дом № " + adress.House + " корпус " + adress.Corpus + " подъезд № " + adress.Entrance)
                                {
                                    subscriberform.comboBox1.SelectedIndex = i;
                                }
                            }
                            for (int i = 0; i < subscriberform.comboBox2.Items.Count; i++)
                            {
                                if (subscriberform.comboBox2.Items[i].ToString() == db.DomofonHandsets.FirstOrDefault(el => el.Id == subscriber.DomofonHandsetId).DomofonHandsetType)
                                {
                                    subscriberform.comboBox2.SelectedIndex = i;
                                }
                            }
                            for (int i = 0; i < subscriberform.comboBox3.Items.Count; i++)
                            {
                                if (subscriberform.comboBox3.Items[i].ToString() == db.DomofonKeys.FirstOrDefault(el => el.Id == subscriber.DomofonKeyId).DomofonKeyType)
                                {
                                    subscriberform.comboBox3.SelectedIndex = i;
                                }
                            }
                            DialogResult result = subscriberform.ShowDialog(this);

                            if (result == DialogResult.Cancel)
                                return;
                            subscriber.Name = subscriberform.textBox1.Text;
                            subscriber.Surname = subscriberform.textBox2.Text;
                            subscriber.Phone = subscriberform.textBox3.Text;
                            subscriber.Flat = (int)subscriberform.numericUpDown1.Value;
                            subscriber.ContractNumb = subscriberform.textBox4.Text;
                            subscriber.ContractDate = subscriberform.dateTimePicker1.Value;
                            subscriber.Code = subscriberform.textBox5.Text;
                            subscriber.Comments = subscriberform.textBox6.Text;
                            var domofonAdresstID = db.Addresses.FirstOrDefault(el => el.Street + " дом № " + el.House + " корпус " + el.Corpus + " подъезд № " + el.Entrance == subscriberform.comboBox1.SelectedItem.ToString());
                            if (domofonAdresstID != null)
                            {
                                subscriber.AddressId = domofonAdresstID.Id;
                            }
                            var domofonHandsetID = db.DomofonHandsets.FirstOrDefault(el => el.DomofonHandsetType == subscriberform.comboBox2.SelectedItem.ToString());
                            if (domofonHandsetID != null)
                            {
                                subscriber.DomofonHandsetId = domofonHandsetID.Id;
                            }
                            var domofonKeyID = db.DomofonKeys.FirstOrDefault(el => el.DomofonKeyType == subscriberform.comboBox3.SelectedItem.ToString());
                            if (domofonKeyID != null)
                            {
                                subscriber.DomofonKeyId = domofonKeyID.Id;
                            }
                            db.SaveChanges();
                            ClearTable();
                            GetAllSubscribersByAdress(idAdress);
                        }
                    }
                    break;
                case "repair":
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        int index = dataGridView1.SelectedRows[0].Index;
                        int id = 0;
                        bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                        if (converted == false)
                            return;
                        using (DomofonContext db = new DomofonContext())
                        {
                            RepairRequest repair = db.RepairRequests.Find(id);
                            RepairForm repairForm = new RepairForm();
                            repairForm.dateTimePicker1.Value = repair.DateRepairBegin;
                            repairForm.idAddress = repair.AddressId;
                            Address repairAddress = db.Addresses.Find(repair.AddressId);
                            string repairAddressToString = repairAddress.Street + " дом № " + repairAddress.House + " корпус " + repairAddress.Corpus + " подъезд № " + repairAddress.Entrance + "; id=" + repairAddress.Id;
                            for (int i = 0; i < repairForm.comboBox1.Items.Count; i++)
                            {
                                if (repairForm.comboBox1.Items[i].ToString() == repairAddressToString)
                                {
                                    repairForm.comboBox1.SelectedIndex = i;
                                }
                            }
                            repairForm.numericUpDown1.Value = repair.Flat;
                            repairForm.textBox3.Text = repair.DescriptionFromSub;
                            repairForm.dateTimePicker2.Value = repair.DateRepairEnd;
                            repairForm.textBox4.Text = repair.DescriptionFromServ;
                            for (int i = 0; i < repairForm.comboBox2.Items.Count; i++)
                            {
                                if (repairForm.comboBox2.Items[i].ToString() == repair.Status)
                                {
                                    repairForm.comboBox2.SelectedIndex = i;
                                }
                            }

                            repairForm.textBox5.Text = repair.Comments;

                            DialogResult result = repairForm.ShowDialog(this);

                            if (result == DialogResult.Cancel)
                                return;
                            repair.DateRepairBegin = repairForm.dateTimePicker1.Value;
                            repair.AddressId = repairForm.idAddress;
                            repair.Flat = (int)repairForm.numericUpDown1.Value;
                            repair.DescriptionFromSub = repairForm.textBox3.Text;
                            repair.DateRepairEnd = repairForm.dateTimePicker2.Value;
                            repair.DescriptionFromServ = repairForm.textBox4.Text;
                            repair.Status = repairForm.comboBox2.SelectedItem.ToString();
                            repair.SubscriberId = repairForm.subscriderID;
                            repair.Comments = repairForm.textBox5.Text;
                            db.SaveChanges();
                            ClearTable();
                            GetAllRepairs();
                        }
                    }
                    break;
                case "adress":
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        int index = dataGridView1.SelectedRows[0].Index;
                        int id = 0;
                        bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                        if (converted == false)
                            return;
                        using (DomofonContext db = new DomofonContext())
                        {
                            Address adress = db.Addresses.Find(id);
                            AddressForm adressform = new AddressForm();
                            adressform.textBox1.Text = adress.City;
                            adressform.textBox2.Text = adress.Street;
                            adressform.numericUpDown1.Value = adress.House;
                            adressform.textBox3.Text = adress.Corpus;
                            adressform.numericUpDown2.Value = adress.Entrance;
                            adressform.textBox5.Text = adress.ContractNumb;
                            adressform.dateTimePicker1.Value = adress.ContractDate;
                            adressform.numericUpDown3.Value = adress.FlatCount;
                            adressform.numericUpDown4.Value = adress.DoorsCount;

                            for (int i = 0; i < adressform.comboBox1.Items.Count; i++)
                            {
                                if (adressform.comboBox1.Items[i].ToString() == db.DomofonSystems.FirstOrDefault(el => el.Id == adress.DomofonSystemId).DomofonSystemType)
                                {
                                    adressform.comboBox1.SelectedIndex = i;
                                }
                            }
                            for (int i = 0; i < adressform.comboBox2.Items.Count; i++)
                            {
                                if (adressform.comboBox2.Items[i].ToString() == db.DomofonKeys.FirstOrDefault(el => el.Id == adress.DomofonKeyId).DomofonKeyType)
                                {
                                    adressform.comboBox2.SelectedIndex = i;
                                }
                            }

                            DialogResult result = adressform.ShowDialog(this);

                            if (result == DialogResult.Cancel)
                                return;
                            adress.City = adressform.textBox1.Text;
                            adress.Street = adressform.textBox2.Text;
                            adress.House = (int)adressform.numericUpDown1.Value;
                            adress.Corpus = adressform.textBox3.Text;
                            adress.Entrance = (int)adressform.numericUpDown2.Value;
                            adress.ContractNumb = adressform.textBox5.Text;
                            adress.ContractDate = adressform.dateTimePicker1.Value;
                            adress.FlatCount = (int)adressform.numericUpDown3.Value;
                            adress.DoorsCount = (int)adressform.numericUpDown4.Value;
                            var domofonSystemID = db.DomofonSystems.FirstOrDefault(el => el.DomofonSystemType == adressform.comboBox1.SelectedItem.ToString());
                            if (domofonSystemID != null)
                            {
                                adress.DomofonSystemId = domofonSystemID.Id;
                            }
                            var domofonKeyID = db.DomofonKeys.FirstOrDefault(el => el.DomofonKeyType == adressform.comboBox2.SelectedItem.ToString());
                            if (domofonKeyID != null)
                            {
                                adress.DomofonKeyId = domofonKeyID.Id;
                            }
                            db.SaveChanges();

                            ClearTable();
                            GetAllAdresses();
                        }
                    }
                    break;
                case "key":
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        int index = dataGridView1.SelectedRows[0].Index;
                        int id = 0;
                        bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                        if (converted == false)
                            return;
                        using (DomofonContext db = new DomofonContext())
                        {
                            DomofonKey key = db.DomofonKeys.Find(id);
                            Key_Handset_Domofon_Form keyForm = new Key_Handset_Domofon_Form("key");
                            keyForm.textBox1.Text = key.DomofonKeyType;
                            keyForm.textBox2.Text = key.Comments;
                            DialogResult result = keyForm.ShowDialog(this);

                            if (result == DialogResult.Cancel)
                                return;
                            key.DomofonKeyType = keyForm.textBox1.Text;
                            key.Comments = keyForm.textBox2.Text;
                            db.SaveChanges();
                            ClearTable();
                            GetAllKeys();
                        }
                    }
                    break;
                case "handset":
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        int index = dataGridView1.SelectedRows[0].Index;
                        int id = 0;
                        bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                        if (converted == false)
                            return;
                        using (DomofonContext db = new DomofonContext())
                        {
                            DomofonHandset handset = db.DomofonHandsets.Find(id);
                            Key_Handset_Domofon_Form handsetForm = new Key_Handset_Domofon_Form("handset");
                            handsetForm.textBox1.Text = handset.DomofonHandsetType;
                            handsetForm.textBox2.Text = handset.Comments;
                            DialogResult result = handsetForm.ShowDialog(this);

                            if (result == DialogResult.Cancel)
                                return;
                            handset.DomofonHandsetType = handsetForm.textBox1.Text;
                            handset.Comments = handsetForm.textBox2.Text;
                            db.SaveChanges();
                            ClearTable();
                            GetAllHandSets();
                        }
                    }
                    break;
                case "domofon":
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        int index = dataGridView1.SelectedRows[0].Index;
                        int id = 0;
                        bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                        if (converted == false)
                            return;
                        using (DomofonContext db = new DomofonContext())
                        {
                            DomofonSystem domofon = db.DomofonSystems.Find(id);
                            Key_Handset_Domofon_Form domofonForm = new Key_Handset_Domofon_Form("domofon");
                            domofonForm.textBox1.Text = domofon.DomofonSystemType;
                            domofonForm.textBox2.Text = domofon.Comments;
                            DialogResult result = domofonForm.ShowDialog(this);

                            if (result == DialogResult.Cancel)
                                return;
                            domofon.DomofonSystemType = domofonForm.textBox1.Text;
                            domofon.Comments = domofonForm.textBox2.Text;
                            db.SaveChanges();
                            ClearTable();
                            GetAllDomofonSystems();
                        }
                    }
                    break;
                case "payments":
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        int ID = (int)dataGridView1[0, 0].Value;
                        int index = dataGridView1.SelectedRows[0].Index;
                        int id = 0;
                        if (dataGridView1[6, index].Value == null)
                        {
                            MessageBox.Show("Не выделена строка с оплатой!", "WARNING");
                            return;
                        }
                        bool converted = Int32.TryParse(dataGridView1[6, index].Value.ToString(), out id);
                        if (converted == false)
                            return;
                        string adress = dataGridView1[0, 1].Value.ToString();
                        string adressFull = adress + " кв. " + dataGridView1[0, 2].Value;
                        using (DomofonContext db = new DomofonContext())
                        {
                            Payment payment = db.Payments.Find(id);
                            PaymentForm paymentForm = new PaymentForm("payments");
                            paymentForm.textBox1.Text = adressFull;
                            paymentForm.dateTimePicker1.Value = payment.SumMinusDate;
                            paymentForm.textBox3.Text = payment.Comments;
                            paymentForm.numericUpDown1.Value = (int)payment.SumMinus;
                            paymentForm.numericUpDown2.Value = payment.SumMinus * 100 % 100;
                            DialogResult result = paymentForm.ShowDialog(this);
                            if (result == DialogResult.Cancel)
                                return;
                            payment.SumMinusDate = paymentForm.dateTimePicker1.Value;
                            payment.Comments = paymentForm.textBox3.Text;
                            payment.SumMinus = paymentForm.numericUpDown1.Value + paymentForm.numericUpDown2.Value / 100;
                            db.SaveChanges();
                            ClearTable();
                            GetSubscriberPayments(ID, adress);
                        }
                        ChangeFontAndColor();
                        payments_btn.Visible = false; //скрываем кнопку "Оплаты"
                        Back_btn.Visible = false; //скрываем кнопку "Назад"
                        ChooseSubs_btn.Enabled = false; //деактивируем кнопку "Выбрать абонента"
                    }
                    break;
                case "accrual":
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        int index = dataGridView1.SelectedRows[0].Index;
                        int id = 0;
                        bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                        if (converted == false)
                            return;
                        using (DomofonContext db = new DomofonContext())
                        {
                            Accrual accrual = db.Accruals.Find(id);
                            PaymentForm paymentForm = new PaymentForm("accrual");
                            paymentForm.textBox1.Text = "ДЛЯ ВСЕХ";
                            paymentForm.dateTimePicker1.Value = accrual.SumPlusDate;
                            paymentForm.textBox3.Text = accrual.Comments;
                            paymentForm.numericUpDown1.Value = (int)accrual.SumPlus;
                            paymentForm.numericUpDown2.Value = accrual.SumPlus * 100 % 100;
                            DialogResult result = paymentForm.ShowDialog(this);
                            if (result == DialogResult.Cancel)
                                return;
                            accrual.SumPlusDate = paymentForm.dateTimePicker1.Value;
                            accrual.Comments = paymentForm.textBox3.Text;
                            accrual.SumPlus = paymentForm.numericUpDown1.Value + paymentForm.numericUpDown2.Value / 100;
                            db.SaveChanges();
                            ClearTable();
                            GetAllAccruals();
                        }
                    }
                    break;
            }
        }

        private void DELL_btn_Click(object sender, EventArgs e)
        {
            switch (activeTable)
            {
                case "company":
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        int index = dataGridView1.SelectedRows[0].Index;
                        int id = 0;
                        bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                        if (converted == false)
                            return;
                        using (DomofonContext db = new DomofonContext())
                        {
                            Company company = db.Companies.Find(id);
                            DialogResult dialogResult = MessageBox.Show("Выдействительно хотите удалить компанию: "
                                + company.Name + " " + company.Address + "?", "WARNING", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                db.Companies.Remove(company);
                                db.SaveChanges();
                            }
                            else if (dialogResult == DialogResult.No)
                                return;
                            ClearTable();
                            GetAllCompanies();
                        }
                    }
                    break;
                case "serviceman":
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        int index = dataGridView1.SelectedRows[0].Index;
                        int id = 0;
                        bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                        if (converted == false)
                            return;

                        using (DomofonContext db = new DomofonContext())
                        {
                            Serviceman serviceman = db.Servicemen.Find(id);
                            DialogResult dialogResult = MessageBox.Show("Выдействительно хотите удалить мастера: "
                                + serviceman.Name + " " + serviceman.Surname + "?", "WARNING", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                db.Servicemen.Remove(serviceman);
                                db.SaveChanges();
                            }
                            else if (dialogResult == DialogResult.No)
                                return;
                            ClearTable();
                            GetAllServiсeman();
                        }
                    }
                    break;
                case "subscriber":
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        int index = dataGridView1.SelectedRows[0].Index;
                        int id = 0;
                        bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                        if (converted == false)
                            return;

                        using (DomofonContext db = new DomofonContext())
                        {
                            Subscriber subscriber = db.Subscribers.Find(id);
                            DialogResult dialogResult = MessageBox.Show("Выдействительно хотите удалить абонента: "
                                + subscriber.Name + " " + subscriber.Surname + ", кв. - "
                                + subscriber.Flat + ", id - " + subscriber.Code + "?", "WARNING", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                db.Subscribers.Remove(subscriber);
                                db.SaveChanges();
                            }
                            else if (dialogResult == DialogResult.No)
                                return;
                            ClearTable();
                            GetAllSubscribersByAdress(idAdress);
                        }
                    }
                    break;
                case "repair":
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        int index = dataGridView1.SelectedRows[0].Index;
                        int id = 0;
                        bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                        if (converted == false)
                            return;
                        using (DomofonContext db = new DomofonContext())
                        {
                            RepairRequest repair = db.RepairRequests.Find(id);
                            DialogResult dialogResult = MessageBox.Show("Выдействительно хотите удалить заявку: "
                                + repair.DescriptionFromSub + " квартиры " + repair.Flat + " от "
                                + repair.DateRepairBegin + "?", "WARNING", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                db.RepairRequests.Remove(repair);
                                db.SaveChanges();
                            }
                            else if (dialogResult == DialogResult.No)
                                return;
                            ClearTable();
                            GetAllRepairs();
                        }
                    }
                    break;
                case "adress":
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        int index = dataGridView1.SelectedRows[0].Index;
                        int id = 0;
                        bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                        if (converted == false)
                            return;

                        using (DomofonContext db = new DomofonContext())
                        {
                            Address adress = db.Addresses.Find(id);
                            DialogResult dialogResult = MessageBox.Show("Выдействительно хотите удалить адрес: "
                                + adress.Street + " дом № " + adress.House + " корпус "
                                + adress.Corpus + " подъезд № " + adress.Entrance + "?", "WARNING", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                db.Addresses.Remove(adress);
                                db.SaveChanges();
                            }
                            else if (dialogResult == DialogResult.No)
                                return;
                            dataGridView1.Refresh();
                            ClearTable();
                            GetAllAdresses();
                        }
                    }
                    break;
                case "key":
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        int index = dataGridView1.SelectedRows[0].Index;
                        int id = 0;
                        bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                        if (converted == false)
                            return;
                        using (DomofonContext db = new DomofonContext())
                        {
                            DomofonKey key = db.DomofonKeys.Find(id);
                            DialogResult dialogResult = MessageBox.Show("Выдействительно хотите удалить ключ: "
                                + key.DomofonKeyType + "?", "WARNING", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                db.DomofonKeys.Remove(key);
                                db.SaveChanges();
                            }
                            else if (dialogResult == DialogResult.No)
                                return;
                            ClearTable();
                            GetAllKeys();
                        }
                    }
                    break;
                case "handset":
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        int index = dataGridView1.SelectedRows[0].Index;
                        int id = 0;
                        bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                        if (converted == false)
                            return;
                        using (DomofonContext db = new DomofonContext())
                        {
                            DomofonHandset handset = db.DomofonHandsets.Find(id);
                            DialogResult dialogResult = MessageBox.Show("Выдействительно хотите удалить трубку: "
                                + handset.DomofonHandsetType + "?", "WARNING", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                db.DomofonHandsets.Remove(handset);
                                db.SaveChanges();
                            }
                            else if (dialogResult == DialogResult.No)
                                return;
                            ClearTable();
                            GetAllHandSets();
                        }
                    }
                    break;
                case "domofon":
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        int index = dataGridView1.SelectedRows[0].Index;
                        int id = 0;
                        bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                        if (converted == false)
                            return;
                        using (DomofonContext db = new DomofonContext())
                        {
                            DomofonSystem domofon = db.DomofonSystems.Find(id);
                            DialogResult dialogResult = MessageBox.Show("Выдействительно хотите удалить домофонную систему: "
                                + domofon.DomofonSystemType + "?", "WARNING", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                db.DomofonSystems.Remove(domofon);
                                db.SaveChanges();
                            }
                            else if (dialogResult == DialogResult.No)
                                return;
                            ClearTable();
                            GetAllDomofonSystems();
                        }
                    }
                    break;
                case "payments":
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        int ID = (int)dataGridView1[0, 0].Value;
                        int index = dataGridView1.SelectedRows[0].Index;
                        int id = 0;
                        if (dataGridView1[6, index].Value == null)
                        {
                            MessageBox.Show("Не выделена строка с оплатой!", "WARNING");
                            return;
                        }
                        bool converted = Int32.TryParse(dataGridView1[6, index].Value.ToString(), out id);
                        if (converted == false)
                            return;
                        string adress = dataGridView1[0, 1].Value.ToString();
                        string adressFull = adress + " кв. " + dataGridView1[0, 2].Value;
                        using (DomofonContext db = new DomofonContext())
                        {
                            Payment payment = db.Payments.Find(id);
                            DialogResult dialogResult = MessageBox.Show("Выдействительно хотите удалить начисление: "
                                + payment.SumMinusDate.ToShortDateString() + " сумма: " + payment.SumMinus + "?", "WARNING", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                db.Payments.Remove(payment);
                                db.SaveChanges();
                            }
                            else if (dialogResult == DialogResult.No)
                                return;
                            ClearTable();
                            GetSubscriberPayments(ID, adress);
                        }
                        ChangeFontAndColor();
                        payments_btn.Visible = false; //скрываем кнопку "Оплаты"
                        Back_btn.Visible = false; //скрываем кнопку "Назад"
                        ChooseSubs_btn.Enabled = false; //деактивируем кнопку "Выбрать абонента"
                    }
                    break;
                case "accrual":
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        int index = dataGridView1.SelectedRows[0].Index;
                        int id = 0;
                        bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                        if (converted == false)
                            return;
                        using (DomofonContext db = new DomofonContext())
                        {
                            Accrual accrual = db.Accruals.Find(id);
                            DialogResult dialogResult = MessageBox.Show("Выдействительно хотите удалить начисление: "
                                + accrual.SumPlusDate.ToShortDateString() + " сумма: " + accrual.SumPlus + "?", "WARNING", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                db.Accruals.Remove(accrual);
                                db.SaveChanges();
                            }
                            else if (dialogResult == DialogResult.No)
                                return;
                            ClearTable();
                            GetAllAccruals();
                        }
                    }
                    break;
            }
        }
        private void ChangeFontAndColor()//функция изменения цвета и размера шрифта
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].DefaultCellStyle.Font = font;
                dataGridView1.Columns[i].DefaultCellStyle.ForeColor = color;
            }
        }
        private void font_ToolStripMenuItem_Click(object sender, EventArgs e)//меню шрифт
        {
            fontDialog1.ShowColor = true;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                font = fontDialog1.Font;
                color = fontDialog1.Color;
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    dataGridView1.Columns[i].DefaultCellStyle.Font = fontDialog1.Font;
                    dataGridView1.Columns[i].DefaultCellStyle.ForeColor = fontDialog1.Color;
                }
            }
        }

        private void color_ToolStripMenuItem_Click(object sender, EventArgs e)//меню цвет
        {
            colorDialog1.Color = dataGridView1.Columns[0].DefaultCellStyle.ForeColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    dataGridView1.Columns[i].DefaultCellStyle.ForeColor = colorDialog1.Color;
                }
            }
        }

        private void default_ToolStripMenuItem_Click(object sender, EventArgs e)//меню установки по умолчанию
        {
            font = new System.Drawing.Font("Comic Sans MS", 12);
            color = Color.Black;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].DefaultCellStyle.Font = font;
                dataGridView1.Columns[i].DefaultCellStyle.ForeColor = color;
            }
        }

        private void about_ToolStripMenuItem_Click(object sender, EventArgs e)//меню о программе
        {
            MessageBox.Show(@"Это программа для работы с абонентами домофонной компании 'PROJECT_DOMOFON ver. 1.0'. 
Разработана в рамках учебной программы Компьютерной Академии ШАГ как курсовой проект по .NET. 
Использовался язык программирования С# и Microsoft Visual Studio Enterprise 2019.
Программист - Дьяконов Кирилл Владимирович, руководитель проекта - Горчинский Сергей Владимирович.
г. Чернигов ноябрь 2021 год. Эта программа для бесплатного ознакомительного распространения.
Для связи - alkiddkv@gmail.com", "О программе");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)//меню выход
        {
            Close();
        }

        private void payments_btn_Click(object sender, EventArgs e)//кнопка "Оплаты"
        {
            switch (activeTable)
            {
                case "adress":
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        int index = dataGridView1.SelectedRows[0].Index;
                        int id = 0;
                        bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                        if (converted == false)
                            return;
                        idAdress = id;
                        ClearTable();
                        using (DomofonContext db = new DomofonContext())
                        {
                            var subscribers = from sub in db.Subscribers
                                              where sub.AddressId == id
                                              select sub;
                            var subscriberList = subscribers.ToList();//делает выборку всех абонентов в подъезде
                            dataGridView1.Columns.Add("col0", "ID");
                            dataGridView1.Columns.Add("col1", "Адрес");
                            dataGridView1.Columns.Add("col2", "Квартира");
                            dataGridView1.Columns.Add("col3", "Имя");
                            dataGridView1.Columns.Add("col4", "Фамилия");
                            dataGridView1.Columns.Add("col5", "ID код");
                            dataGridView1.Columns.Add("col6", "Всего начислено");
                            dataGridView1.Columns.Add("col7", "Всего оплачено");
                            dataGridView1.Columns.Add("col8", "Разница");
                            dataGridView1.Columns.Add("col9", "Общая задолженность");
                            var accrual = from acc in db.Accruals
                                          select acc;
                            decimal totalAccrual = 0;
                            foreach (var el in accrual)
                            {
                                totalAccrual += el.SumPlus;//суммирует все суммы начислений
                            }
                            foreach (var item in subscriberList)
                            {
                                var subPayment = from pay in db.Payments
                                                 where pay.SubscriberId == item.Id
                                                 select pay;
                                var sumList = subPayment.ToList();
                                decimal totalSumm = 0;
                                foreach (var sum in sumList)
                                {
                                    totalSumm += sum.SumMinus;//сумма всех оплат определенного абонента
                                }

                                dataGridView1.Rows.Add(item.Id, db.Addresses.FirstOrDefault(el => el.Id == id).Street + " № "
                                    + db.Addresses.FirstOrDefault(el => el.Id == id).House
                                    + " к. " + db.Addresses.FirstOrDefault(el => el.Id == id).Corpus
                                    + " п. " + db.Addresses.FirstOrDefault(el => el.Id == id).Entrance,
                                    item.Flat, item.Name, item.Surname, item.Code, totalAccrual, totalSumm, totalAccrual - totalSumm);//8-й столбец если будет знак "-" - значит у человека переплата
                            }
                        }
                    }
                    dataGridView1.Refresh();
                    decimal totalDebt = 0;//общая сумма задолженности подъезда
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        decimal sum = 0;
                        bool convert = Decimal.TryParse(dataGridView1[8, i].Value.ToString(), out sum);
                        if (convert == false)
                            return;
                        if (sum > 0)//суммируем только должников, ведь со знаком "-" у человека переплата
                            totalDebt += sum;
                    }
                    dataGridView1[9, 0].Value = totalDebt;//в десятой колонке выводим общуюю сумму задолжености
                    activeTable = "subscriber";//активируем таблицу subscriber
                    Back_btn.Visible = true; //отобразить кнопку "Назад"
                    ChooseSubs_btn.Enabled = false; //деактивируем кнопку "Выбрать абонента"
                    ChangeFontAndColor();
                    label1.Text = "Операции с абонентами:";
                    break;
                case "subscriber":
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        int index = dataGridView1.SelectedRows[0].Index;
                        int id = 0;
                        bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                        if (converted == false)
                            return;
                        string adress = dataGridView1[1, index].Value.ToString();
                        ClearTable();
                        GetSubscriberPayments(id, adress);
                        payments_btn.Visible = false; //скрываем кнопку "Оплаты"
                        Back_btn.Visible = true; //скрываем кнопку "Назад"
                        ChooseSubs_btn.Enabled = false; //деактивируем кнопку "Выбрать абонента"
                        label1.Text = "Операции с платежами:";
                    }
                    activeTable = "payments";//активируем таблицу payments
                    ChangeFontAndColor();
                    break;
            }
        }
        public void GetSubscriberPayments(int ID, string adress)
        {
            using (DomofonContext db = new DomofonContext())
            {
                Subscriber subscriber = db.Subscribers.Find(ID);
                dataGridView1.Columns.Add("col0", "ID");
                dataGridView1.Columns.Add("col1", "Даты начислений");
                dataGridView1.Columns.Add("col2", "Начисления");
                dataGridView1.Columns.Add("col3", "Даты оплат");
                dataGridView1.Columns.Add("col4", "Оплаты");
                dataGridView1.Columns.Add("col5", "Общая задолженность");
                dataGridView1.Columns.Add("col6", "id oплаты");
                decimal totalAccrual = 0;
                decimal totalSumm = 0;
                var paymentsList = from payments in db.Payments
                                   where payments.SubscriberId == subscriber.Id
                                   select payments;

                var accrualList = from accruals in db.Accruals
                                      //where accruals.SubscriberId == subscriber.Id                                                  
                                  select accruals;

                var allAccruals = accrualList.ToList();
                var allPayments = paymentsList.ToList();
                void AddPayments()
                {
                    for (int i = 0; i < allPayments.Count(); i++)
                    {
                        dataGridView1[3, i].Value = allPayments[i].SumMinusDate.ToShortDateString();
                        dataGridView1[4, i].Value = allPayments[i].SumMinus;
                        dataGridView1[6, i].Value = allPayments[i].Id;
                        totalSumm += allPayments[i].SumMinus;
                    }
                }
                void AddAccruals()
                {
                    for (int i = 0; i < allAccruals.Count(); i++)
                    {
                        dataGridView1[1, i].Value = allAccruals[i].SumPlusDate.ToShortDateString();
                        dataGridView1[2, i].Value = allAccruals[i].SumPlus;
                        totalAccrual += allAccruals[i].SumPlus;
                    }
                }
                if (accrualList.Count() >= paymentsList.Count())
                {
                    if (accrualList.Count() <= 6)//проверяем количесвто строк, чтобы добавить строки для данных абонента
                    {
                        for (int i = 0; i < 6; i++)
                            dataGridView1.Rows.Add();
                    }
                    else
                    {
                        for (int i = 0; i < accrualList.Count(); i++)
                        {
                            dataGridView1.Rows.Add();
                        }
                        AddAccruals();
                        AddPayments();
                    }
                }
                else
                {
                    if (paymentsList.Count() <= 6)
                    {
                        for (int i = 0; i < 6; i++)
                            dataGridView1.Rows.Add();
                    }
                    else
                    {
                        for (int i = 0; i < paymentsList.Count(); i++)
                        {
                            dataGridView1.Rows.Add();
                        }
                        AddPayments();
                        AddAccruals();
                    }
                }

                decimal totalDebit = totalAccrual - totalSumm;
                dataGridView1[0, 0].Value = subscriber.Id;
                dataGridView1[0, 1].Value = adress;
                dataGridView1[0, 2].Value = "кв. " + subscriber.Flat;
                dataGridView1[0, 3].Value = subscriber.Name;
                dataGridView1[0, 4].Value = subscriber.Surname;
                dataGridView1[0, 5].Value = subscriber.Code;

                DateTime today = new DateTime();
                today = DateTime.Now;
                dataGridView1[5, 0].Value = "По состоянию на " + today.ToShortDateString();
                if (totalDebit >= 0)
                    dataGridView1[5, 1].Value = "Долг: " + totalDebit;//в пятой колонке выводим общуюю сумму задолжености
                else
                    dataGridView1[5, 1].Value = "Переплата: " + totalDebit;
                dataGridView1.Columns[6].Visible = false;
            }
        }
        public void AddAccrual()
        {
            ClearTable();
            PaymentForm paymentForm = new PaymentForm("accrual");
            DialogResult dialogResult = paymentForm.ShowDialog(this);
            if (dialogResult == DialogResult.Cancel)
                return;
            using (DomofonContext db = new DomofonContext())
            {
                Accrual accrual = new Accrual();
                accrual.SumPlusDate = paymentForm.dateTimePicker1.Value;
                accrual.SumPlus = paymentForm.numericUpDown1.Value + paymentForm.numericUpDown2.Value / 100;
                accrual.Comments = paymentForm.textBox3.Text;
                db.Accruals.Add(accrual);
                db.SaveChanges();
            }
            ChangeFontAndColor();
            payments_btn.Visible = false; //скрываем кнопку "Оплаты"
            Back_btn.Visible = false; //скрываем кнопку "Назад"
            ChooseSubs_btn.Enabled = false; //деактивируем кнопку "Выбрать абонента"
            label1.Text = "Операции с начислениями:";
        }
        private void makeAccrualToolStripMenuItem_Click(object sender, EventArgs e)//меню начисление абонплаты
        {
            AddAccrual();
            GetAllAccruals();
            activeTable = "accrual";
        }

        private void generalReportToolStripMenuItem_Click(object sender, EventArgs e)//меню Общий отчет текущего состояния
        {
            ClearTable();
            using (DomofonContext db = new DomofonContext())
            {
                dataGridView1.Columns.Add("col0", "Наименование");
                dataGridView1.Columns.Add("col1", "Количество");
                var company = from c in db.Companies
                              select c;
                foreach (var item in company)
                {
                    dataGridView1.Rows.Add(item.Name, item.Address);
                }
                var address = from a in db.Addresses
                              select a;
                int numberOfAdress = address.Count();
                dataGridView1.Rows.Add("Всего подъездов", numberOfAdress);
                var subscribers = from s in db.Subscribers
                                  select s;
                int numberOfSubscribers = subscribers.Count();
                dataGridView1.Rows.Add("Всего абонентов", numberOfSubscribers);

                decimal sumOfAllAccruals = db.Accruals.Sum(acc => acc.SumPlus);
                var allSub = from pay in db.Payments //коллекция всех оплат
                             join sub in db.Subscribers on pay.SubscriberId equals sub.Id
                             orderby sub.Name + " " + sub.Surname
                             select pay;

                dataGridView1.Rows.Add("Всего начислено", sumOfAllAccruals);

                var allSubList = allSub.ToList(); //приводим ее к List
                var groupSubscribers = allSubList.GroupBy(x => x.SubscriberId).Select(g => new { SubId = g.Key, Sum = g.Sum(c => c.SumMinus) });//группируем оплаты по абонентам

                dataGridView1.Rows.Add("ID должника", "Сумма");

                int numberOfDebtors = 0; //количество должников
                decimal totalDebt = 0;   // общая задолженность
                foreach (var item in groupSubscribers)
                {
                    if ((item.Sum - sumOfAllAccruals) < 0) //если есть задолженность
                    {
                        numberOfDebtors++;    //увеличиваем кол-во должников
                        totalDebt += (item.Sum - sumOfAllAccruals); //суммируем задолженность
                    }
                }

                dataGridView1.Rows.Add("Всего должников", numberOfDebtors);
                dataGridView1.Rows.Add("На сумму", totalDebt);

                var domofonSys = from ds in db.DomofonSystems
                                 join adr in db.Addresses on ds.Id equals adr.DomofonSystemId
                                 orderby ds.DomofonSystemType
                                 select ds;
                var domofonSysList = domofonSys.ToList();
                var domofonCount = domofonSysList.GroupBy(item => item).Select(item => new { Name = item.Key.DomofonSystemType, Count = item.Count() }).OrderByDescending(item => item.Count).ThenBy(item => item.Name);
                dataGridView1.Rows.Add("Установленно систем", "Количество:");

                foreach (var item in domofonCount)
                {
                    dataGridView1.Rows.Add(item.Name, item.Count);
                }

                var handset = from hs in db.DomofonHandsets
                              join sub in db.Subscribers on hs.Id equals sub.DomofonHandsetId
                              orderby hs.DomofonHandsetType
                              select hs;

                var handsetList = handset.ToList();
                var handsetCount = handsetList.GroupBy(item => item).Select(item => new { Name = item.Key.DomofonHandsetType, Count = item.Count() }).OrderByDescending(item => item.Count).ThenBy(item => item.Name);
                dataGridView1.Rows.Add("Установленно трубок", "Количество:");
                foreach (var item in handsetCount)
                {
                    dataGridView1.Rows.Add(item.Name, item.Count);
                }
                dataGridView1.Rows.Add("Заявок в работе", "Количество:");
                var repairs = from rep in db.RepairRequests
                              where rep.Status == "В работе"
                              select rep;
                int repairsNumber = repairs.Count();
                dataGridView1.Rows.Add("", repairsNumber);

            }
            ChangeFontAndColor();
            payments_btn.Visible = false; //скрываем кнопку "Оплаты"
            Back_btn.Visible = false; //скрываем кнопку "Назад"
            ChooseSubs_btn.Enabled = false; //деактивируем кнопку "Выбрать абонента"
            activeTable = "";
            label1.Text = "Операции приостановлены:";
        }

        private void Back_btn_Click(object sender, EventArgs e)//обработчик кнопки назад
        {
            switch (activeTable)
            {
                case "subscriber":
                    ClearTable();
                    GetAllAdresses();
                    activeTable = "adress";
                    break;
                case "payments":
                    GetAllSubscribersByAdress(idAdress);
                    ChangeFontAndColor();
                    activeTable = "subscriber";
                    break;
            }
        }

        private void findSurnameToolStripMenuItem_Click(object sender, EventArgs e)//обработчик меню поиск по фамилии
        {
            ClearTable();
            FindForm findForm = new FindForm("surname");
            DialogResult dialogResult = findForm.ShowDialog(this);
            if (dialogResult == DialogResult.Cancel)
                return;
            using (DomofonContext db = new DomofonContext())
            {
                string surname = "";

                if (String.IsNullOrEmpty(findForm.textBox1.Text))
                {
                    MessageBox.Show("Введите фамилию!", "WARNING");
                    return;
                }
                else surname = findForm.textBox1.Text;
                Subscriber subscriber = new Subscriber();
                subscriber = db.Subscribers.FirstOrDefault(el => el.Surname == surname);

                if (subscriber == null)
                {
                    MessageBox.Show("Совпадений не найдено!", "ERROR");
                    label1.Text = "Операции приостановлены:";
                    activeTable = "";
                    return;
                }

                dataGridView1.Columns.Add("col0", "ID");
                dataGridView1.Columns.Add("col1", "Адрес");
                dataGridView1.Columns.Add("col2", "Квартира");
                dataGridView1.Columns.Add("col3", "Имя");
                dataGridView1.Columns.Add("col4", "Фамилия");
                dataGridView1.Columns.Add("col5", "Телефон");
                dataGridView1.Columns.Add("col6", "№ договора");
                dataGridView1.Columns.Add("col7", "Дата договора");
                dataGridView1.Columns.Add("col8", "ID код");
                dataGridView1.Columns.Add("col9", "Трубка");
                dataGridView1.Columns.Add("col10", "Ключ");
                dataGridView1.Columns.Add("col11", "Комментарии");
                dataGridView1.Rows.Add(subscriber.Id, db.Addresses.FirstOrDefault(el => el.Id == subscriber.AddressId).Street + " № "
                    + db.Addresses.FirstOrDefault(el => el.Id == subscriber.AddressId).House
                    + "к. " + db.Addresses.FirstOrDefault(el => el.Id == subscriber.AddressId).Corpus
                    + " п. " + db.Addresses.FirstOrDefault(el => el.Id == subscriber.AddressId).Entrance,
                    subscriber.Flat, subscriber.Name, subscriber.Surname, subscriber.Phone, subscriber.ContractNumb, subscriber.ContractDate.ToShortDateString(),
                    subscriber.Code, db.DomofonHandsets.FirstOrDefault(el => el.Id == subscriber.DomofonHandsetId).DomofonHandsetType,
                    db.DomofonKeys.FirstOrDefault(el => el.Id == subscriber.DomofonKeyId).DomofonKeyType, subscriber.Comments);

                idAdress = subscriber.AddressId;

            }
            ChangeFontAndColor();
            payments_btn.Visible = true; //отобразить кнопку "Оплаты"
            Back_btn.Visible = false; //скрываем кнопку "Назад"
            ChooseSubs_btn.Enabled = false; //деактивируем кнопку "Выбрать абонента"
            label1.Text = "Операции с абонентами:";
            activeTable = "subscriber";

        }

        private void findCodeToolStripMenuItem_Click(object sender, EventArgs e)//обработчик меню поиск по коду
        {
            ClearTable();
            FindForm findForm = new FindForm("code");
            DialogResult dialogResult = findForm.ShowDialog(this);
            if (dialogResult == DialogResult.Cancel)
                return;
            using (DomofonContext db = new DomofonContext())
            {
                string code = "";

                if (String.IsNullOrEmpty(findForm.textBox1.Text))
                {
                    MessageBox.Show("Введите код!", "WARNING");
                    return;
                }
                else code = findForm.textBox1.Text;
                Subscriber subscriber = new Subscriber();
                subscriber = db.Subscribers.FirstOrDefault(el => el.Code == code);

                if (subscriber == null)
                {
                    MessageBox.Show("Совпадений не найдено!", "ERROR");
                    label1.Text = "Операции приостановлены:";
                    activeTable = "";
                    return;
                }

                dataGridView1.Columns.Add("col0", "ID");
                dataGridView1.Columns.Add("col1", "Адрес");
                dataGridView1.Columns.Add("col2", "Квартира");
                dataGridView1.Columns.Add("col3", "Имя");
                dataGridView1.Columns.Add("col4", "Фамилия");
                dataGridView1.Columns.Add("col5", "Телефон");
                dataGridView1.Columns.Add("col6", "№ договора");
                dataGridView1.Columns.Add("col7", "Дата договора");
                dataGridView1.Columns.Add("col8", "ID код");
                dataGridView1.Columns.Add("col9", "Трубка");
                dataGridView1.Columns.Add("col10", "Ключ");
                dataGridView1.Columns.Add("col11", "Комментарии");
                dataGridView1.Rows.Add(subscriber.Id, db.Addresses.FirstOrDefault(el => el.Id == subscriber.AddressId).Street + " № "
                    + db.Addresses.FirstOrDefault(el => el.Id == subscriber.AddressId).House
                    + "к. " + db.Addresses.FirstOrDefault(el => el.Id == subscriber.AddressId).Corpus
                    + " п. " + db.Addresses.FirstOrDefault(el => el.Id == subscriber.AddressId).Entrance,
                    subscriber.Flat, subscriber.Name, subscriber.Surname, subscriber.Phone, subscriber.ContractNumb, subscriber.ContractDate.ToShortDateString(),
                    subscriber.Code, db.DomofonHandsets.FirstOrDefault(el => el.Id == subscriber.DomofonHandsetId).DomofonHandsetType,
                    db.DomofonKeys.FirstOrDefault(el => el.Id == subscriber.DomofonKeyId).DomofonKeyType, subscriber.Comments);

                idAdress = subscriber.AddressId;

            }
            ChangeFontAndColor();
            payments_btn.Visible = true; //отобразить кнопку "Оплаты"
            Back_btn.Visible = false; //скрываем кнопку "Назад"
            ChooseSubs_btn.Enabled = false; //деактивируем кнопку "Выбрать абонента"
            label1.Text = "Операции с абонентами:";
            activeTable = "subscriber";
        }

        private void keysToAddressToolStripMenuItem_Click(object sender, EventArgs e)//кнопка меню "Ключи по адресам"
        {
            ClearTable();
            using (DomofonContext db = new DomofonContext())
            {
                var adress = db.Addresses.ToList();
                dataGridView1.Columns.Add("col0", "Улица");
                dataGridView1.Columns.Add("col1", "Дом");
                dataGridView1.Columns.Add("col2", "Корпус");
                dataGridView1.Columns.Add("col3", "Подъезд");
                dataGridView1.Columns.Add("col4", "Тип домофона");
                dataGridView1.Columns.Add("col5", "Тип ключей");

                foreach (var item in adress)
                {
                    dataGridView1.Rows.Add(item.Street, item.House,
                        item.Corpus, item.Entrance,
                        db.DomofonSystems.FirstOrDefault(el => el.Id == item.DomofonSystemId).DomofonSystemType,
                        db.DomofonKeys.FirstOrDefault(el => el.Id == item.DomofonKeyId).DomofonKeyType);
                }
            }
            ChangeFontAndColor();
            payments_btn.Visible = false; //скрываем кнопку "Оплаты"
            Back_btn.Visible = false; //скрываем кнопку "Назад"
            ChooseSubs_btn.Enabled = false; //деактивируем кнопку "Выбрать абонента"
            label1.Text = "Операции приостановлены:";
            activeTable = "";
        }

        private void debtorsToolStripMenuItem_Click(object sender, EventArgs e)//вывод списка должников
        {
            if (activeTable != "adress")
            {
                MessageBox.Show("Выберите один адрес в списке адресов", "WARNING!!!");
                return;
            }
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                idAdress = id;
                ClearTable();
                using (DomofonContext db = new DomofonContext())
                {
                    var subscribers = from sub in db.Subscribers
                                      where sub.AddressId == id
                                      select sub;
                    var subscriberList = subscribers.ToList();//делает выборку всех абонентов в подъезде
                    dataGridView1.Columns.Add("col0", "ID");
                    dataGridView1.Columns.Add("col1", "Адрес");
                    dataGridView1.Columns.Add("col2", "Квартира");
                    dataGridView1.Columns.Add("col3", "ID код");
                    dataGridView1.Columns.Add("col4", "Долг");
                    dataGridView1.Columns.Add("col5", "Общая задолженность");
                    var accrual = from acc in db.Accruals
                                  select acc;
                    decimal totalAccrual = 0;
                    foreach (var el in accrual)
                    {
                        totalAccrual += el.SumPlus;//суммирует все суммы начислений
                    }
                    foreach (var item in subscriberList)
                    {
                        var subPayment = from pay in db.Payments
                                         where pay.SubscriberId == item.Id
                                         select pay;
                        var sumList = subPayment.ToList();
                        decimal totalSumm = 0;
                        foreach (var sum in sumList)
                        {
                            totalSumm += sum.SumMinus;//сумма всех оплат определенного абонента
                        }
                        if (totalAccrual - totalSumm > 0)
                        {
                            dataGridView1.Rows.Add(item.Id, db.Addresses.FirstOrDefault(el => el.Id == id).Street + " № "
                            + db.Addresses.FirstOrDefault(el => el.Id == id).House
                            + " к. " + db.Addresses.FirstOrDefault(el => el.Id == id).Corpus
                            + " п. " + db.Addresses.FirstOrDefault(el => el.Id == id).Entrance,
                            item.Flat, item.Code, totalAccrual - totalSumm);
                        }
                    }
                }
            }
            dataGridView1.Refresh();
            decimal totalDebt = 0;//общая сумма задолженности подъезда
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                decimal sum = 0;
                bool convert = Decimal.TryParse(dataGridView1[4, i].Value.ToString(), out sum);
                if (convert == false)
                    return;
                if (sum > 0)//суммируем только должников, ведь со знаком "-" у человека переплата
                    totalDebt += sum;
            }
            dataGridView1[5, 0].Value = totalDebt;//в шестой колонке выводим общуюю сумму задолжености
            activeTable = "";//дэактивируем таблицу subscriber
            ChangeFontAndColor();
            payments_btn.Visible = false; //скрываем кнопку "Оплаты"
            Back_btn.Visible = false; //скрываем кнопку "Назад"
            ChooseSubs_btn.Enabled = false; //деактивируем кнопку "Выбрать абонента"
            label1.Text = "Операции приостановлены:";
        }
        public List<float> MakeHeader(List<int> headers) 
            // функция возвращает лист заголовков в процентном соотношении
            // к длине каждого заголовка в зависимости от содержимого
        {
            int totalLength = 0;
            int totalHeaderNumber = headers.Count();
            foreach (var item in headers)
                totalLength += item;
            List<float> calculatedList = new List<float>();
            foreach(var item in headers)
                calculatedList.Add((item * 100 / totalLength));

            return calculatedList;
        }
        public void ExportGridToPdf(DataGridView dgw, string filename)//ф-я переносит данные из dataGridView в файл pdf формата
        {
            //настройка таблицы
            PdfPTable pdfTable = new PdfPTable(dgw.Columns.Count);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;
            
            // создаем шрифт для отображения содержимого таблицы
            BaseFont baseFont = BaseFont.CreateFont("..\\..\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
            //добавляем заголовки
            List<int> headers = new List<int>();//список заголовков для перерасчета их длин в проценты
            foreach (DataGridViewColumn column in dgw.Columns)
            {
                headers.Add(column.Width);
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);//заголовки делаем серым цветом
                pdfTable.AddCell(cell);
            }
            List<float> headersFloat = MakeHeader(headers);//делаем перерасчет заголовков
            pdfTable.SetWidths(headersFloat.ToArray());//задаем ширину каждого столбца таблицы
            //добавляем данные в таблицу
            foreach (DataGridViewRow row in dgw.Rows)
            {
                foreach(DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        pdfTable.AddCell(new Phrase(cell.Value.ToString(), font));
                    }
                    else
                        pdfTable.AddCell(new Phrase("", font));
                }
            }
            var savefiledialog = new SaveFileDialog();
            savefiledialog.FileName = filename;
            savefiledialog.DefaultExt = ".pdf";
            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialog.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4.Rotate(), 20f, 20f, 20f, 0f);//лист А4 - альбомная ориентация и отступы о краев
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdfTable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }
        private void saveToPDF_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportGridToPdf(dataGridView1, "test");

            MessageBox.Show("Pdf-документ сохранен");
        }

        private void repairs_by_date_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearTable();
            Repairs_By_Date repairsByDate = new Repairs_By_Date();
            DialogResult dialogResult = repairsByDate.ShowDialog(this);
            if (dialogResult == DialogResult.Cancel)
                return;
            DateTime findDate = repairsByDate.dateTimePicker1.Value;
            using (DomofonContext db = new DomofonContext())
            {
                var repairs = db.RepairRequests.Where(r => DbFunctions.TruncateTime(r.DateRepairEnd) == DbFunctions.TruncateTime(findDate));

                var allRepairs = repairs.ToList();
                dataGridView1.Columns.Add("col0", "№");
                dataGridView1.Columns.Add("col1", "Адрес");
                dataGridView1.Columns.Add("col2", "Кв.");
                dataGridView1.Columns.Add("col3", "Заявленная неисправность");
                dataGridView1.Columns.Add("col4", "Время вып");
                dataGridView1.Columns.Add("col5", "Отметки про выполнение мастера");
                dataGridView1.Columns.Add("col6", "Кв.");
                dataGridView1.Columns.Add("col7", "Фамилия");
                dataGridView1.Columns.Add("col8", "Подпись");

                int numberOfRepair = 1;
                foreach (var item in allRepairs)
                {
                    dataGridView1.Rows.Add(numberOfRepair, db.Addresses.FirstOrDefault(el => el.Id == item.AddressId).Street + " № "
                        + db.Addresses.FirstOrDefault(el => el.Id == item.AddressId).House
                        + "к. " + db.Addresses.FirstOrDefault(el => el.Id == item.AddressId).Corpus
                        + " п. " + db.Addresses.FirstOrDefault(el => el.Id == item.AddressId).Entrance, item.Flat,
                        item.DescriptionFromSub, "", "", "", "", "");
                    numberOfRepair++;
                }
            }

            ChangeFontAndColor();
            payments_btn.Visible = false; //скрываем кнопку "Оплаты"
            Back_btn.Visible = false; //скрываем кнопку "Назад"
            ChooseSubs_btn.Enabled = false; //деактивируем кнопку "Выбрать абонента"
            label1.Text = "Операции приостановлены:";
            activeTable = "";
        }

        private void repairs_by_subscriber_ToolStripMenuItem_Click(object sender, EventArgs e)//все завки по выбранному абоненту
        {
            if (activeTable != "subscriber")
            {
                MessageBox.Show("Выберите одного абонента в списке абонетов", "WARNING!!!");
                return;
            }
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                ClearTable();
                using (DomofonContext db = new DomofonContext())
                {
                    var repairs = from rep in db.RepairRequests
                                  where rep.SubscriberId.Value == id
                                  select rep;
                    var allRepairs = repairs.ToList();
                    dataGridView1.Columns.Add("col0", "ID");
                    dataGridView1.Columns.Add("col1", "Дата заявки");
                    dataGridView1.Columns.Add("col2", "Адрес");
                    dataGridView1.Columns.Add("col3", "Квартира");
                    dataGridView1.Columns.Add("col4", "Заявленная неисправность");
                    dataGridView1.Columns.Add("col5", "Дата выполнения");
                    dataGridView1.Columns.Add("col6", "Что ремонтировалось");
                    dataGridView1.Columns.Add("col7", "Статус");
                    dataGridView1.Columns.Add("col8", "Абонент");
                    dataGridView1.Columns.Add("col9", "Комментарии");

                    foreach (var item in allRepairs)
                    {
                        dataGridView1.Rows.Add(item.Id, item.DateRepairBegin.ToShortDateString(), db.Addresses.FirstOrDefault(el => el.Id == item.AddressId).Street + " № "
                            + db.Addresses.FirstOrDefault(el => el.Id == item.AddressId).House
                            + "к. " + db.Addresses.FirstOrDefault(el => el.Id == item.AddressId).Corpus
                            + " п. " + db.Addresses.FirstOrDefault(el => el.Id == item.AddressId).Entrance, item.Flat,
                            item.DescriptionFromSub, item.DateRepairEnd.ToShortDateString(), item.DescriptionFromServ,
                            item.Status, item.SubscriberId, item.Comments);
                    }
                }
            }
            ChangeFontAndColor();
            payments_btn.Visible = false; //скрываем кнопку "Оплаты"
            Back_btn.Visible = false; //скрываем кнопку "Назад"
            ChooseSubs_btn.Enabled = false; //деактивируем кнопку "Выбрать абонента"
            label1.Text = "Операции приостановлены:";
            activeTable = "";
        }

        private void repairs_by_address_ToolStripMenuItem_Click(object sender, EventArgs e)//все завки по выбранному адресу
        {
            if (activeTable != "adress")
            {
                MessageBox.Show("Выберите один адрес в списке адресов", "WARNING!!!");
                return;
            }
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                ClearTable();
                using (DomofonContext db = new DomofonContext())
                {
                    var repairs = from rep in db.RepairRequests
                                  where rep.AddressId == id
                                  select rep;
                    var allRepairs = repairs.ToList();
                    dataGridView1.Columns.Add("col0", "ID");
                    dataGridView1.Columns.Add("col1", "Дата заявки");
                    dataGridView1.Columns.Add("col2", "Адрес");
                    dataGridView1.Columns.Add("col3", "Квартира");
                    dataGridView1.Columns.Add("col4", "Заявленная неисправность");
                    dataGridView1.Columns.Add("col5", "Дата выполнения");
                    dataGridView1.Columns.Add("col6", "Что ремонтировалось");
                    dataGridView1.Columns.Add("col7", "Статус");
                    dataGridView1.Columns.Add("col8", "Абонент");
                    dataGridView1.Columns.Add("col9", "Комментарии");

                    foreach (var item in allRepairs)
                    {
                        dataGridView1.Rows.Add(item.Id, item.DateRepairBegin.ToShortDateString(), db.Addresses.FirstOrDefault(el => el.Id == item.AddressId).Street + " № "
                            + db.Addresses.FirstOrDefault(el => el.Id == item.AddressId).House
                            + "к. " + db.Addresses.FirstOrDefault(el => el.Id == item.AddressId).Corpus
                            + " п. " + db.Addresses.FirstOrDefault(el => el.Id == item.AddressId).Entrance, item.Flat,
                            item.DescriptionFromSub, item.DateRepairEnd.ToShortDateString(), item.DescriptionFromServ,
                            item.Status, item.SubscriberId, item.Comments);
                    }
                }
            }
                ChangeFontAndColor();
            payments_btn.Visible = false; //скрываем кнопку "Оплаты"
            Back_btn.Visible = false; //скрываем кнопку "Назад"
            ChooseSubs_btn.Enabled = false; //деактивируем кнопку "Выбрать абонента"
            label1.Text = "Операции приостановлены:";
            activeTable = "";
        }
        public void PrintRepairsToPdf(DataGridView dgw, string filename)//ф-я переносит данные из dataGridView в файл pdf формата
        {
            //настройка таблицы
            PdfPTable pdfTable = new PdfPTable(dgw.Columns.Count);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            // создаем шрифт для отображения содержимого таблицы
            BaseFont baseFont = BaseFont.CreateFont("..\\..\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
            // создаем шрифт для отображения содержимого заголовка плана-задания
            iTextSharp.text.Font fontHead = new iTextSharp.text.Font(baseFont, 16, iTextSharp.text.Font.BOLD);
            // создаем шрифт для отображения содержимого текста плана-задания
            iTextSharp.text.Font fontText = new iTextSharp.text.Font(baseFont, 16, iTextSharp.text.Font.NORMAL);

            //Добавим в таблицу общий заголовок
            string head = @"                                         ПЛАН-ЗАДАНИЕ
            выполнения заявленных ремонтных работ по техническому обслуживанию
            установленных домофонных систем на '____'______________20___ года
            Данный план-задание является одновременно и Актом выполненных работ.
            Работы выполнял мастер: ____________________________________________.
 ";
            PdfPCell cellHead = new PdfPCell(new Phrase(head, fontHead));

            cellHead.Colspan = dgw.Columns.Count;
            cellHead.HorizontalAlignment = 0;
            //Убираем границу первой ячейки, чтобы была как заголовок
            cellHead.Border = 0;
            pdfTable.AddCell(cellHead);

            //добавляем заголовки
            List<int> headers = new List<int>();//список заголовков для перерасчета их длин в проценты
            foreach (DataGridViewColumn column in dgw.Columns)
            {
                headers.Add(column.Width);
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);//заголовки делаем серым цветом
                pdfTable.AddCell(cell);
            }
            List<float> headersFloat = MakeHeader(headers);//делаем перерасчет заголовков
            pdfTable.SetWidths(headersFloat.ToArray());//задаем ширину каждого столбца таблицы
            //добавляем данные в таблицу
            foreach (DataGridViewRow row in dgw.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        pdfTable.AddCell(new Phrase(cell.Value.ToString(), font));
                    }
                    else
                        pdfTable.AddCell(new Phrase("", font));
                }
            }
            var savefiledialog = new SaveFileDialog();
            savefiledialog.FileName = filename;
            savefiledialog.DefaultExt = ".pdf";
            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialog.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4.Rotate(), 20f, 20f, 20f, 0f);//лист А4 - альбомная ориентация и отступы о краев
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdfTable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }

        private void Prin_Repairs_ToolStripMenuItem_Click(object sender, EventArgs e)//меню печать для мастеров Плана-задания
        {
            PrintRepairsToPdf(dataGridView1, "план-задание");

            MessageBox.Show("план-задание-документ сохранен");
        }

        private void help_ToolStripMenuItem_Click(object sender, EventArgs e)//меню Помощь
        {
            try
            {
                Process.Start(@"..\..\manual\Manual.pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ФАЙЛ НЕ НАЙДЕН!!!");
            }
        }
    }
}
