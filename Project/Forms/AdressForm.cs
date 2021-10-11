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
    public partial class AdressForm : Form
    {
        public AdressForm()
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
                var keys = db.DomofonKeys.ToList();
                foreach(var item in keys)
                {
                    comboBox2.Items.Add(item.DomofonKeyType);
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
