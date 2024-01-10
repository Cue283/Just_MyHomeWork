using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float score;
            float mid;
            float final;
            mid = int.Parse(midterm.Text);
            final = int.Parse(finalu.Text);
            score = mid + final;
            if(score >=80  && score <= 100 ) {
                MessageBox.Show("Grade A");
            }
            else if (score >= 70 && score < 80 )
            {
                MessageBox.Show("Grade B ");
            }
            else if (score >= 60 && score < 70)
            {
                MessageBox.Show("Grade C ");
            }
            else if (score >= 50 && score < 60)
            {
                MessageBox.Show("Grade D ");
            }
            else if (score <= 49 && score == 0)
            {
                MessageBox.Show("Grade F ");
            }
            else { MessageBox.Show("N"); }
        }
    }
}
