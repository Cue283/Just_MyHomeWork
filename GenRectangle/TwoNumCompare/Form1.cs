using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoNumCompare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            float No1;
            float No2;
            No1 = float.Parse(num1.Text);
            No2 = float.Parse(num2.Text);
            if (No1 < No2) {
                MessageBox.Show("Number1 < Number2");
            }
            else if(No1 > No2)
            {
                MessageBox.Show("Numer1 > Number2");
            }
            else { MessageBox.Show("Number1=Number2"); }

        }
    }
}
