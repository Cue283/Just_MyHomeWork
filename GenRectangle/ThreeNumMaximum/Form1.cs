using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeNumMaximum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            list.Add(int.Parse((num1).Text));
            list.Add(int.Parse((num2).Text));
            list.Add(int.Parse((num3).Text));

            int max = list.Max();
            int maxIndex = list.IndexOf(max)+1;
            MessageBox.Show("Maximun is " + max + ",index is" + maxIndex);
        }
    }
}
