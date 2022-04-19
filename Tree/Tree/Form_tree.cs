using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tree
{
    public partial class Form_tree : Form
    {
        public Form_tree()
        {
            InitializeComponent();
        }
        public Form_tree(List<int> new_list)
        {
            InitializeComponent();
            foreach (int i in new_list)
            {
                textBox1.Text += Convert.ToString(i) + "     ";
                textBox1.Text += "\r\n";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
