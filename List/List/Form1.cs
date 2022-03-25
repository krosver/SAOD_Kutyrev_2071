using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MyList<int> new_list = new MyList<int>();
        private void bt_append_Click(object sender, EventArgs e)
        {
            new_list.Append(Convert.ToInt32(tb_append.Text));
            write_list();
        }

        private void bt_prepend_Click(object sender, EventArgs e)
        {
            new_list.Prepend(Convert.ToInt32(tb_prepend.Text));
            write_list();
        }

        private void bt_insert_Click(object sender, EventArgs e)
        {
            new_list.Insert(Convert.ToInt32(tb_insert.Text));
            write_list();
        }

        private void bt_find_Click(object sender, EventArgs e)
        {
            new_list.Find(Convert.ToInt32(tb_find.Text));
            write_list();
        }
        private void write_list()
        {
            listBox1.Items.Clear();
            foreach (int i in new_list.ToArray())
            {
                listBox1.Items.Add(i);
            }
        }
    }
}
