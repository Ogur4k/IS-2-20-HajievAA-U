﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_2_20_HajievAA_U
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Ex1 x1 = new Ex1();
            x1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ex2 x2 = new Ex2();
            x2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ex3 x3 = new Ex3();
            x3.ShowDialog();
        }
    }
}
