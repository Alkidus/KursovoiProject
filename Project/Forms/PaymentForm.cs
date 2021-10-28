using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class PaymentForm : Form
    {
        public PaymentForm(string tableName)
        {
            InitializeComponent();
            Text = "PAYMENT_DOMOFON";
            BackColor = Color.Aquamarine;
            switch (tableName)
            {
                case "accrual":
                    Text = "Add_ACCRUAL_DOMOFON";
                    textBox1.Text = "ДЛЯ ВСЕХ";
                    label8.Text = "Дата начисления:";
                    break;
                case "payment":
                    Text = "Add_PAYMENT_DOMOFON";
                    label8.Text = "Дата оплаты:";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
