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
    public partial class SubscriberForm : Form
    {
        public SubscriberForm()
        {
            InitializeComponent();
            Text = "SUBSCRIBER_DOMOFON";
            this.BackColor = Color.Aquamarine;
            
            using (DomofonContext db = new DomofonContext())
            {
                var adresses = db.Adresses.ToList();
                foreach(var item in adresses)
                {
                    comboBox1.Items.Add(item.Street + " дом № " + item.House + " корпус " + item.Corpus + " подъезд № " + item.Entrance);
                }
                var keys = db.DomofonKeys.ToList();
                foreach (var item in keys)
                {
                    comboBox3.Items.Add(item.DomofonKeyType);
                }
                var handsets = db.DomofonHandsets.ToList();
                foreach (var item in handsets)
                {
                    comboBox2.Items.Add(item.DomofonHandsetType);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
