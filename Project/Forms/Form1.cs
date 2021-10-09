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
                CompanyName = "К.С-Инвест",
                CompanyAdress = "г.Чернигов, ул. Родимцева 14",//адрес
                CompanyPhone = "+38 (0462) 614-681",//тедефон
                CompanyAccount = "UA133052990000026008006300527",//расчетный счет в банке
                CompanyCode = "33660167",//код ЕДРПОУ
                CompanyBankCode = "305299"// МФО банка
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

        private void Adress_btn_Click(object sender, EventArgs e)
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
                dataGridView1.Columns.Add("col7", "FlatCount");
                dataGridView1.Columns.Add("col8", "DoorsCount");
                dataGridView1.Columns.Add("col9", "DomofonSystemId");
                dataGridView1.Columns.Add("col10", "DomofonKeyId");

                foreach (var item in adress)
                {
                    dataGridView1.Rows.Add(item.Id, item.City, item.Street, 
                        item.House, item.Corpus, item.Entrance, 
                        item.ContractNumb, item.FlatCount, item.DoorsCount,
                        item.DomofonSystemId, item.DomofonKeyId);
                }
            }
        }
    }
}
