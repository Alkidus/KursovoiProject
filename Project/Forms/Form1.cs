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
                    dataGridView1.Rows.Add(item.Id, item.CompanyName, item.CompanyAdress, item.CompanyPhone, item.CompanyAccount, item.CompanyCode, item.CompanyBankCode);
                }
            }
        }
    }
}
