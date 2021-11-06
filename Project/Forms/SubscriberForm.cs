﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Controller;
using Project.Models;

namespace Project.Forms
{
    public partial class SubscriberForm : Form
    {
        public int idAdress = 0;
        public SubscriberForm(int ID)
        {
            InitializeComponent();
            idAdress = ID;
            Text = "SUBSCRIBER_DOMOFON";
            BackColor = Color.Aquamarine;
            
            using (DomofonContext db = new DomofonContext())
            {
                var adresses = db.Adresses.ToList();
                foreach(var item in adresses)
                {
                    comboBox1.Items.Add(item.Street + " дом № " + item.House + " корпус " + item.Corpus + " подъезд № " + item.Entrance);
                }
                Address adress = db.Adresses.Find(idAdress);
                comboBox1.SelectedItem = adress.Street + " дом № " + adress.House + " корпус " + adress.Corpus + " подъезд № " + adress.Entrance;
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
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            string flatNumber = numericUpDown1.Value.ToString();
            while (flatNumber.Length < 3)
                flatNumber = "0" + flatNumber;
            using (DomofonContext db = new DomofonContext())
            {
                Address adress = db.Adresses.Find(idAdress);
                textBox4.Text = adress.ContractNumb + flatNumber;
                textBox5.Text = "500" + adress.ContractNumb + flatNumber;
            }
        }
    }
}
