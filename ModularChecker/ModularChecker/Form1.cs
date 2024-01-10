 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModularChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(tung.Text);
            int num2 = int.Parse(har.Text);
            if (checkMod(num1, num2))
                MessageBox.Show(num1 + "เป็นผลคูณของ" + num2 + "เนื่องจาก" + num2 + "คูณกับตัวเลขใดๆ แล้วมีค่าเท่ากับ" + num1);
            
            else
                MessageBox.Show(num1 + "ไม่เป็นผลคูณของ" + num2 + "เนื่องจาก" + num2 + "ไม่สามารถคูณกับตัวเลขใดๆ แล้วมีค่าเท่ากับ" + num1);
            
        }
        public Boolean checkMod(int a, int b) 
        {
             if ( a%b == 0)
                return true;
            
             else
            
                return false;
            
              
        }

        
    }
}
