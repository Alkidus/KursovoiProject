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

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "PROJECT_DOMOFON";
            this.BackColor = Color.Aquamarine;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Company myCompany = new Company
            //{
            //    Name = "К.С-Инвест",
            //    Adress = "г.Чернигов, ул. Родимцева 14",//адрес
            //    Phone = "+38 (0462) 614-681",//тедефон
            //    Account = "UA133052990000026008006300527",//расчетный счет в банке
            //    Code = "33660167",//код ЕДРПОУ
            //    BankCode = "305299"// МФО банка
            //};

            using(DomofonContext db = new DomofonContext())
            {
                db.Companies.Add(
                    new Company
                    {
                        Name = "К.С-Инвест",
                        Adress = "г.Чернигов, ул. Родимцева 14",//адрес
                        Phone = "+38 (0462) 614-681",//тедефон
                        Account = "UA133052990000026008006300527",//расчетный счет в банке
                        Code = "33660167",//код ЕДРПОУ
                        BankCode = "305299"// МФО банка
                    }
                );
                db.Servicemen.Add(new Serviceman { Name = "Петя", Surname = "Павленко", Phone = "0937033817" });
                db.Servicemen.Add(new Serviceman { Name = "Кирилл", Surname = "Павленко", Phone = "0934163083" });
                db.DomofonHandsets.Add(
                    new DomofonHandset
                    {
                        DomofonHandsetType = "SmartEl"
                    });
                db.DomofonHandsets.Add(
                    new DomofonHandset
                    {
                        DomofonHandsetType = "ТАП-02"
                    });
                db.DomofonHandsets.Add(
                    new DomofonHandset
                    {
                        DomofonHandsetType = "УКП-7"
                    });
                db.DomofonHandsets.Add(
                    new DomofonHandset
                    {
                        DomofonHandsetType = "УКП-12"
                    });
                db.DomofonHandsets.Add(
                    new DomofonHandset
                    {
                        DomofonHandsetType = "УКП-12М"
                    });
                db.DomofonHandsets.Add(
                    new DomofonHandset
                    {
                        DomofonHandsetType = "ВИДЕО"
                    });
                db.DomofonHandsets.Add(
                    new DomofonHandset
                    {
                        DomofonHandsetType = "Другое"
                    });
                db.DomofonKeys.Add(
                    new DomofonKey
                    {
                        DomofonKeyType = "АДК"
                    });
                db.DomofonKeys.Add(
                    new DomofonKey
                    {
                        DomofonKeyType = "Беркут ТМ"
                    });
                db.DomofonKeys.Add(
                    new DomofonKey
                    {
                        DomofonKeyType = "Беркут RC",
                        DomofonKeyCode = "310"
                    });
                db.DomofonKeys.Add(
                    new DomofonKey
                    {
                        DomofonKeyType = "Беркут RC",
                        DomofonKeyCode = "T470"
                    });
                db.DomofonKeys.Add(
                    new DomofonKey
                    {
                        DomofonKeyType = "Беркут RC",
                        DomofonKeyCode = "2K4"
                    });
                db.DomofonKeys.Add(
                    new DomofonKey
                    {
                        DomofonKeyType = "Беркут RC",
                        DomofonKeyCode = "T6K8"
                    });
                db.DomofonKeys.Add(
                    new DomofonKey
                    {
                        DomofonKeyType = "Vizit RF-2.1"
                    });
                db.DomofonKeys.Add(
                    new DomofonKey
                    {
                        DomofonKeyType = "Cyfral Dallas"
                    });
                db.DomofonSystems.Add(
                    new DomofonSystem
                    {
                        DomofonSystemType = "АДК"
                    });
                db.DomofonSystems.Add(
                    new DomofonSystem
                    {
                        DomofonSystemType = "Беркут"
                    });
                db.DomofonSystems.Add(
                new DomofonSystem
                    {
                        DomofonSystemType = "Vizit"
                    });
                db.DomofonSystems.Add(
                new DomofonSystem
                    {
                        DomofonSystemType = "Cyfral"
                    });
                db.DomofonSystems.Add(
                new DomofonSystem
                    {
                        DomofonSystemType = "Беркут SmartEl"
                    });
                db.Adresses.Add(
                    new Adress
                    {
                        City = "Чернигов",
                        Street = "Ивана Мазепы",
                        House = 33,
                        Entrance = 4,
                        ContractNumb = "697",
                        ContractDate = new DateTime(2010, 10, 12),
                        FlatCount = 15,
                        DoorsCount = 1,
                        DomofonSystemId = 3,
                        DomofonKeyId = 7
                    });
                db.Adresses.Add(
                    new Adress
                    {
                        City = "Чернигов",
                        Street = "Мстиславского",
                        House = 34,
                        Entrance = 1,
                        ContractNumb = "481",
                        ContractDate = new DateTime(2008, 05, 11),
                        FlatCount = 36,
                        DoorsCount = 1,
                        DomofonSystemId = 2,
                        DomofonKeyId = 4
                    });
                db.Adresses.Add(
                    new Adress
                    {
                        City = "Чернигов",
                        Street = "Попудренко",
                        House = 12,
                        Corpus = "Б",
                        Entrance = 3,
                        ContractNumb = "218",
                        ContractDate = new DateTime(2012, 02, 22),
                        FlatCount = 15,
                        DoorsCount = 1,
                        DomofonSystemId = 4,
                        DomofonKeyId = 8
                    });
                db.Subscribers.Add(
                    new Subscriber
                    {
                        Name = "Тамара",
                        Surname = "Мельникова",
                        Phone = "+380683871920",
                        Flat = 57,
                        ContractNumb = "221",
                        ContractDate = new DateTime(2010, 10, 21),
                        Code = "500697057",
                        AdressId = 1,
                        DomofonHandsetId = 3,
                        DomofonKeyId = 7,
                        Comments = "Хочет поменять на видеодомофон"
                    });
                db.Subscribers.Add(
                    new Subscriber
                    {
                        Name = "Антонина",
                        Surname = "Вивденко",
                        Phone = "+380504652012",
                        Flat = 56,
                        ContractNumb = "220",
                        ContractDate = new DateTime(2010, 10, 20),
                        Code = "500697056",
                        AdressId = 1,
                        DomofonHandsetId = 4,
                        DomofonKeyId = 7
                    });
                db.Subscribers.Add(
                    new Subscriber
                    {
                        Name = "Сергей",
                        Surname = "Шурубенко",
                        Phone = "+380502216025",
                        Flat = 59,
                        ContractNumb = "223",
                        ContractDate = new DateTime(2015, 11, 11),
                        Code = "500697059",
                        AdressId = 1,
                        DomofonHandsetId = 5,
                        DomofonKeyId = 7
                    });
                db.Subscribers.Add(
                    new Subscriber
                    {
                        Name = "Андрей",
                        Surname = "Древа",
                        Phone = "+380685528956",
                        Flat = 5,
                        ContractNumb = "17",
                        ContractDate = new DateTime(2012, 12, 12),
                        Code = "500481005",
                        AdressId = 2,
                        DomofonHandsetId = 1,
                        DomofonKeyId = 4
                    });
                db.Subscribers.Add(
                    new Subscriber
                    {
                        Name = "Владимир",
                        Surname = "Королёв",
                        Phone = "+38972689541",
                        Flat = 13,
                        ContractNumb = "23",
                        ContractDate = new DateTime(2014, 02, 16),
                        Code = "500481013",
                        AdressId = 2,
                        DomofonHandsetId = 2,
                        DomofonKeyId = 4
                    });
                db.Subscribers.Add(
                    new Subscriber
                    {
                        Name = "Марина",
                        Surname = "Огурец",
                        Phone = "+380502020100",
                        Flat = 40,
                        ContractNumb = "20",
                        ContractDate = new DateTime(2017, 10, 20),
                        Code = "500218040",
                        AdressId = 3,
                        DomofonHandsetId = 3,
                        DomofonKeyId = 8
                    });


                db.SaveChanges();
            }
            GetAllCompanies();
        }
        private void GetAllCompanies()
        {
            using (DomofonContext db = new DomofonContext())
            {
                var comp = db.Companies.ToList();
                dataGridView1.Columns.Add("col0", "ID");
                dataGridView1.Columns.Add("col1", "Name");
                dataGridView1.Columns.Add("col2", "Adress");
                dataGridView1.Columns.Add("col3", "Phone");
                dataGridView1.Columns.Add("col4", "Account");
                dataGridView1.Columns.Add("col5", "Code");
                dataGridView1.Columns.Add("col6", "BankCode");

                foreach (var item in comp)
                {
                    dataGridView1.Rows.Add(item.Id, item.Name, item.Adress, item.Phone, item.Account, item.Code, item.BankCode);
                }
            }
        }

        private void GetAllAdresses()
        {
            using (DomofonContext db = new DomofonContext())
            {
                var adress = db.Adresses.ToList();
                dataGridView1.Columns.Add("col0", "ID");
                dataGridView1.Columns.Add("col1", "City");
                dataGridView1.Columns.Add("col2", "Street");
                dataGridView1.Columns.Add("col3", "House");
                dataGridView1.Columns.Add("col4", "Corpus");
                dataGridView1.Columns.Add("col5", "Entrance");
                dataGridView1.Columns.Add("col6", "ContractNumb");
                dataGridView1.Columns.Add("col7", "ContractDate");
                dataGridView1.Columns.Add("col8", "FlatCount");
                dataGridView1.Columns.Add("col9", "DoorsCount");
                dataGridView1.Columns.Add("col10", "DomofonSystemId");
                dataGridView1.Columns.Add("col11", "DomofonKeyId");

                foreach (var item in adress)
                {
                    dataGridView1.Rows.Add(item.Id, item.City, item.Street, item.House,
                        item.Corpus, item.Entrance, item.ContractNumb, item.ContractDate,
                        item.FlatCount, item.DoorsCount, item.DomofonSystemId, item.DomofonKeyId);
                }
            }
        }
        private void Adress_btn_Click(object sender, EventArgs e)
        {
            GetAllAdresses();
        }

        private void Keys_btn_Click(object sender, EventArgs e)
        {
            GetAllKeys();
        }

        private void GetAllKeys()
        {
            using (DomofonContext db = new DomofonContext())
            {
                var keys = db.DomofonKeys.ToList();
                dataGridView1.Columns.Add("col0", "ID");
                dataGridView1.Columns.Add("col1", "DomofonKeyType");
                dataGridView1.Columns.Add("col2", "DomofonKeyCode");

                foreach (var item in keys)
                {
                    dataGridView1.Rows.Add(item.Id, item.DomofonKeyType, item.DomofonKeyCode);
                }
            }
        }

        private void HandSet_btn_Click(object sender, EventArgs e)
        {
            GetAllHandSets();
        }

        private void GetAllHandSets()
        {
            using (DomofonContext db = new DomofonContext())
            {
                var handsets = db.DomofonHandsets.ToList();
                dataGridView1.Columns.Add("col0", "ID");
                dataGridView1.Columns.Add("col1", "DomofonHandsetType");
                dataGridView1.Columns.Add("col2", "Comments");

                foreach (var item in handsets)
                {
                    dataGridView1.Rows.Add(item.Id, item.DomofonHandsetType, item.Comments);
                }
            }
        }

        private void Domofons_btn_Click(object sender, EventArgs e)
        {
            GetAllDomofonSystems();
        }

        private void GetAllDomofonSystems()
        {
            using (DomofonContext db = new DomofonContext())
            {
                var domofonsystems = db.DomofonSystems.ToList();
                dataGridView1.Columns.Add("col0", "ID");
                dataGridView1.Columns.Add("col1", "DomofonSystemType");
                dataGridView1.Columns.Add("col2", "Comments");

                foreach (var item in domofonsystems)
                {
                    dataGridView1.Rows.Add(item.Id, item.DomofonSystemType, item.Comments);
                }
            }
        }

        private void addServiсemanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetAllServiсeman();
        }

        private void GetAllServiсeman()
        {
            using (DomofonContext db = new DomofonContext())
            {
                var servicemen = db.Servicemen.ToList();
                dataGridView1.Columns.Add("col0", "ID");
                dataGridView1.Columns.Add("col1", "Name");
                dataGridView1.Columns.Add("col2", "Surname");
                dataGridView1.Columns.Add("col3", "Phone");

                foreach (var item in servicemen)
                {
                    dataGridView1.Rows.Add(item.Id, item.Name, item.Surname, item.Phone);
                }
            }
        }
    }
}
