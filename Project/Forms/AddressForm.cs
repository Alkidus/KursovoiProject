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
    public partial class AddressForm : Form
    {
        public AddressForm()
        {
            InitializeComponent();
            Text = "ADRESS_DOMOFON";
            this.BackColor = Color.Aquamarine;
            using (DomofonContext db = new DomofonContext())
            {
                var domofom = db.DomofonSystems.ToList();
                foreach (var item in domofom)
                {
                    comboBox1.Items.Add(item.DomofonSystemType);
                }
                comboBox1.SelectedItem = domofom.FirstOrDefault().DomofonSystemType;
                var keys = db.DomofonKeys.ToList();
                foreach(var item in keys)
                {
                    comboBox2.Items.Add(item.DomofonKeyType);
                }
                comboBox2.SelectedItem = keys.FirstOrDefault().DomofonKeyType;
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
