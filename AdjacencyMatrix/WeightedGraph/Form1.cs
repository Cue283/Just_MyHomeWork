using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeightedGraph
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            srcComboBox.Items.AddRange(vertex_list);
            srcComboBox.Text = vertex_list[0];
            descComboBox.Items.AddRange(vertex_list);
            descComboBox.Text = vertex_list[0];
        }
        string[] vertex_list = new string[] { "A", "B", "C", "D", "E","F" };
        int[,] adj_list = new int[,] {{0,   523, 345, 0,   0,  0},
                                      {523, 0,   200, 548, 0,  0},
                                      {345, 200, 0,   360, 467,0},
                                      {0,   548, 360, 245, 0,  0},
                                      {0,   0,   467, 245, 0,  555},
                                      {0,   0,   0,   320, 555,0}
        };
        private void calButton_Click(object sender, EventArgs e)
        {
            int src_index = srcComboBox.SelectedIndex;
            int desc_index = descComboBox.SelectedIndex;
            distanceTextBox.Text =
            adj_list[src_index, desc_index].ToString();
        }
    }
}
