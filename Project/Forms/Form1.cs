using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Models;
using Project.Controller;
using Project.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public string activeTable = "";//переменная для определения выбранной таблицы
        public Font font = new Font("Comic Sans MS", 12);//шрифт в dataGridView по умолчанию
        public Color color = Color.Black;//цвет текста в dataGridView по умолчанию
        public int idAdress = 0;//переменная для хранения айдишника выбранного адреса
        public Form1()
        {
            InitializeComponent();
            Text = "PROJECT_DOMOFON";
            //this.BackColor = Color.Aquamarine;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (DomofonContext db = new DomofonContext())
            {
            //    db.Companies.Add(
            //        new Company
            //        {
            //            Name = "К.С-Инвест",
            //            Adress = "г.Чернигов, ул. Родимцева 14",//адрес
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
            //            DomofonHandsetType = "SmartEl"
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
            //            DomofonHandsetType = "ВИДЕО"
            //        });
            //    db.DomofonHandsets.Add(
            //        new DomofonHandset
            //        {
            //            DomofonHandsetType = "Другое"
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
            //    db.Adresses.Add(
            //        new Adress
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
            //    db.Adresses.Add(
            //        new Adress
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
            //    db.Adresses.Add(
            //        new Adress
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
            //            AdressId = 1,
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
            //            AdressId = 1,
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
            //            AdressId = 1,
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
            //            AdressId = 2,
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
            //            AdressId = 2,
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
            //            AdressId = 3,
            //            DomofonHandsetId = 3,
            //            DomofonKeyId = 8
            //        });


            //    db.SaveChanges();
            }
            GetAllCompanies();
            activeTable = "company";
        }
        private void GetAllCompanies()
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
                    dataGridView1.Rows.Add(item.Id, item.Name, item.Adress, item.Phone, item.Account, item.Code, item.BankCode);
                }
            }
            ChangeFontAndColor();
        }

        private void GetAllAdresses()
        {
            using (DomofonContext db = new DomofonContext())
            {
                var adress = db.Adresses.ToList();
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
            ChangeFontAndColor();
        }
        private void Adress_btn_Click(object sender, EventArgs e)
        {
            ClearTable();
            GetAllAdresses();
            activeTable = "adress";
        }

        private void Keys_btn_Click(object sender, EventArgs e)
        {
            ClearTable();
            GetAllKeys();
            activeTable = "key";
        }

        private void GetAllKeys()
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
            ClearTable();
            using (DomofonContext db = new DomofonContext())
            {
                var subscribers = from sub in db.Subscribers
                                  where sub.AdressId == ID
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
                    dataGridView1.Rows.Add(item.Id, db.Adresses.FirstOrDefault(el => el.Id == ID).Street + " № "
                        + db.Adresses.FirstOrDefault(el => el.Id == ID).House
                        + "к. " + db.Adresses.FirstOrDefault(el => el.Id == ID).Corpus
                        + " п. " + db.Adresses.FirstOrDefault(el => el.Id == ID).Entrance,
                        item.Flat, item.Name, item.Surname, item.Phone, item.ContractNumb, item.ContractDate.ToShortDateString(),
                        item.Code, db.DomofonHandsets.FirstOrDefault(el => el.Id == item.DomofonHandsetId).DomofonHandsetType,
                        db.DomofonKeys.FirstOrDefault(el => el.Id == item.DomofonKeyId).DomofonKeyType, item.Comments);
                }
            }
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

                foreach (var item in repairs)
                {
                    dataGridView1.Rows.Add(item.Id, item.DateRepairBegin, item.AdressId, item.Flat,
                        item.DescriptionFromSub, item.DateRepairEnd, item.DescriptionFromServ,
                        item.Status, item.SubscriberId, item.Comments);
                }
            }
            ChangeFontAndColor();
        }

        private void ADD_btn_Click(object sender, EventArgs e)
        {
            DialogResult result;
            switch (activeTable)
            {
                case "company":
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
                        var domofonAdresstID = db.Adresses.FirstOrDefault(el => el.Street + " дом № " + el.House + " корпус " + el.Corpus + " подъезд № " + el.Entrance == subscriberform.comboBox1.SelectedItem.ToString());
                        if (domofonAdresstID != null)
                        {
                            subscriber.AdressId = domofonAdresstID.Id;
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
                        db.Subscribers.Add(subscriber);
                        db.SaveChanges();
                        ClearTable();
                        GetAllSubscribersByAdress(idAdress);
                    }
                        break;
                case "repair":
                    break;
                case "adress":
                    AdressForm adressform = new AdressForm();
                    result = adressform.ShowDialog(this);
                    if (result == DialogResult.Cancel)
                        return;
                    using (DomofonContext db = new DomofonContext())
                    {
                        Adress adress = new Adress();
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
                        db.Adresses.Add(adress);
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
                                var adress = db.Adresses.FirstOrDefault(el => el.Id == subscriber.AdressId);
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
                            var domofonAdresstID = db.Adresses.FirstOrDefault(el => el.Street + " дом № " + el.House + " корпус " + el.Corpus + " подъезд № " + el.Entrance == subscriberform.comboBox1.SelectedItem.ToString());
                            if (domofonAdresstID != null)
                            {
                                subscriber.AdressId = domofonAdresstID.Id;
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
                            Adress adress = db.Adresses.Find(id);
                            AdressForm adressform = new AdressForm();
                            adressform.textBox1.Text = adress.City;
                            adressform.textBox2.Text = adress.Street;
                            adressform.numericUpDown1.Value = adress.House;
                            adressform.textBox3.Text = adress.Corpus;
                            adressform.numericUpDown2.Value = adress.Entrance;
                            adressform.textBox5.Text = adress.ContractNumb;
                            adressform.dateTimePicker1.Value = adress.ContractDate;
                            adressform.numericUpDown3.Value = adress.FlatCount;
                            adressform.numericUpDown4.Value = adress.DoorsCount;
                            //adressform.comboBox1.SelectedItem = db.DomofonSystems.FirstOrDefault(el => el.Id == adress.DomofonSystemId).DomofonSystemType;
                            //adressform.comboBox2.SelectedItem = db.DomofonKeys.FirstOrDefault(el => el.Id == adress.DomofonKeyId);
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
                            //dataGridView1.Refresh(); // обновляем грид
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
                            Adress adress = db.Adresses.Find(id);
                            DialogResult dialogResult = MessageBox.Show("Выдействительно хотите удалить адрес: "
                                + adress.Street + " дом № " + adress.House + " корпус "
                                + adress.Corpus + " подъезд № " + adress.Entrance + "?", "WARNING", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                db.Adresses.Remove(adress);
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
        private void font_ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void color_ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void default_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            font = new Font("Comic Sans MS", 12);
            color = Color.Black;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].DefaultCellStyle.Font = font;
                dataGridView1.Columns[i].DefaultCellStyle.ForeColor = color;
            }
        }

        private void about_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Это программа для работы с абонентами домофонной компании 'PROJECT_DOMOFON ver. 1.0'. 
Разработана в рамках учебной программы Компьютерной Академии ШАГ как курсовой проект по .NET. 
Использовался язык программирования С# и Microsoft Visual Studio Enterprise 2019.
Программист - Дьяконов Кирилл Владимирович, руководитель проекта - Горчинский Сергей Владимирович.
г. Чернигов ноябрь 2021 год. Эта программа для бесплатного ознакомительного распространения.
Для связи - alkiddkv@gmail.com", "О программе");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
