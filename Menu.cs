using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z3;
using Z1;
using Z2;
using Z4;

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
            Form x1 = new Ex1();
            x1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form x2 = new Ex2();
            x2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form x3 = new Ex3();
            x3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form x4 = new Ex4();
            x4.ShowDialog();
        }
    }
}
