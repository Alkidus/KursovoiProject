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
            Company myCompany = new Company
            {
                Name = "К.С-Инвест",
                Adress = "г.Чернигов, ул. Родимцева 14",//адрес
                Phone = "+38 (0462) 614-681",//тедефон
                Account = "UA133052990000026008006300527",//расчетный счет в банке
                Code = "33660167",//код ЕДРПОУ
                BankCode = "305299"// МФО банка
            };

            using(DomofonContext db = new DomofonContext())
            {
                db.Companies.Add(myCompany);
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
