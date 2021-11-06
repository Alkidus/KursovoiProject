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
    public partial class FindForm : Form
    {
        public FindForm(string findType)
        {
            InitializeComponent();
            switch (findType) 
            {
                case "code":
                    BackColor = Color.LightYellow;
                    Text = "ПОИСК АБОНЕНТА ПО КОДУ";
                    label1.Text = "Введите код:";
                    break;
                case "surname":
                    BackColor = Color.LightPink;
                    Text = "ПОИСК АБОНЕНТА ПО ФАМИЛИИ";
                    label1.Text = "Введите фамилию:";
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
