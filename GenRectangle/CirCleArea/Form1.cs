using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CirCleArea
{
    public partial class Form1 : Form
    {
        const float PI = 3.141f;
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            float Radius;
            float Area;
            float Line;
            Radius = float.Parse(txtRadius.Text);
            Area = PI * (Radius * Radius);
            Line = 2 * PI * Radius;
            MessageBox.Show("พื้นที่เท่ากับ : " + Area + "\nเส้นรอบวงเท่ากับ : " + Line, "ผลการคำนวณ");
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtRadius_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
