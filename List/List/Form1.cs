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
            try
            {
                textBox1.Text = new_list.Find(Convert.ToInt32(tb_find.Text)).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            write_list();
        }
        private void bt_find_index_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = new_list.FindByIndex(Convert.ToInt32(tb_find_index.Text)).ToString();
            }
            catch(IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }                
            write_list();
        }
        private void br_remove_Click(object sender, EventArgs e)
        {
            try
            {
                new_list.Remove(Convert.ToInt32(tb_remove.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            write_list();
        }
        private void bt_remove_index_Click(object sender, EventArgs e)
        {
            try
            {
                new_list.RemoveByIndex(Convert.ToInt32(tb_remove_index.Text));
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
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
