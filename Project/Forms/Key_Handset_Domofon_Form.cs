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
    public partial class Key_Handset_Domofon_Form : Form
    {
        public Key_Handset_Domofon_Form(string tableName)
        {
            InitializeComponent();
            Text = "KEY_HANDSET_DOMOFONSYSTEM";
            BackColor = Color.Aquamarine;
            switch (tableName)
            {
                case "key":
                    Text = "AddKEY_DOMOFON";
                    label1.Text = "Тип домофонного ключа:";
                    break;
                case "handset":
                    Text = "AddHANDSET_DOMOFON";
                    label1.Text = "Тип домофонной трубки:";
                    break;
                case "domofon":
                    Text = "AddDOMOFONSYSTEM_DOMOFON";
                    label1.Text = "Тип домофонной системы:";
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
