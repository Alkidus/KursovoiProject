using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Controller;

namespace Project.Forms
{
    public partial class RepairForm : Form
    {
        public int idAddress = 0;
        public int? subscriderID = null;
        public RepairForm()
        {
            InitializeComponent();
            Text = "РЕДАКТИРОВАНИЕ ЗАЯВОК";
            BackColor = Color.Aquamarine;
            using (DomofonContext db = new DomofonContext())
            {
                var addresses = db.Addresses.ToList();
                foreach (var item in addresses)
                {
                    comboBox1.Items.Add(item.Street + " дом № " + item.House + " корпус " + item.Corpus + " подъезд № " + item.Entrance + "; id=" + item.Id);
                }
            }
            comboBox1.SelectedIndex = 0;
            comboBox2.Items.Add("В работе");
            comboBox2.Items.Add("Выполнена");
            comboBox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int flatNumber = (int)numericUpDown1.Value;

            using (DomofonContext db = new DomofonContext())
            {
                var accrual = from acc in db.Accruals
                              select acc;
                decimal totalAccrual = 0;
                foreach (var el in accrual)
                {
                    totalAccrual += el.SumPlus;//суммирует все суммы начислений
                }

                var subscriber = db.Subscribers.FirstOrDefault(el => el.Flat == flatNumber && el.AddressId == idAddress);
                if (subscriber != null)
                {
                    subscriderID = subscriber.Id; 
                    var subPayment = from pay in db.Payments
                                     where pay.SubscriberId == subscriderID
                                     select pay;
                    var sumList = subPayment.ToList();
                    decimal totalSumm = 0;
                    foreach (var sum in sumList)
                    {
                        totalSumm += sum.SumMinus; //сумма всех оплат абонента
                    }
                    decimal debt = totalAccrual - totalSumm; // сумма долга абонента, положительная при долге и отрицательная при переплате
                    if (debt > 0)
                    {
                        textBox5.Text = "Внимание абонент должник! Долг - " + debt;
                        BackColor = Color.Red;
                    }
                    else if (debt <= 0)
                    {
                        textBox5.Text = "У абонента переплата! Сумма - " + debt;
                        BackColor = Color.Green;
                    }
                }
                else
                {
                    textBox5.Text = "";
                    BackColor = Color.Aquamarine;
                }

                    
            }
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedAddress = comboBox1.SelectedItem.ToString();
            int position = selectedAddress.IndexOf("=");
            idAddress = Convert.ToInt32(selectedAddress.Substring(position + 1));//получаем id выбранного адреса
        }
    }
}
