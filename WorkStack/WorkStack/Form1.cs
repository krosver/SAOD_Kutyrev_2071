using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkStack
{
    public partial class Form1 : Form
    {
        public MyStack<int> new_stack;
        public int[] mas;
        public Form1()
        {
            InitializeComponent();
        }
        private bool NoNull(TextBox tb)
        {
            bool flag = false;
            if (tb.TextLength != 0)
                flag = true;
            return flag;
        }

        private void bt_push_Click(object sender, EventArgs e)
        {
            if (NoNull(tb_push))
            {
                new_stack.Push(Convert.ToInt32(tb_push.Text));
                tb_arr.Clear();
                mas = new_stack.ToArray();
                foreach (int i in mas)
                {
                    tb_arr.Text += i + "\r\n";
                }
            }
            else
            {
                MessageBox.Show("Не введено число");
            }
        }

        private void bt_Pop_Click(object sender, EventArgs e)
        {
            if (NoNull(tb_arr))
            {
                tb_pop.Text = Convert.ToString(new_stack.Pop());
                tb_arr.Clear();
                mas = new_stack.ToArray();
                foreach (int i in mas)
                {
                    tb_arr.Text += i + "\r\n";
                }
                tb_arr.Refresh();
            }
            else
                MessageBox.Show("Пустой массив");

        }

        private void bt_top_Click(object sender, EventArgs e)
        {
            if (NoNull(tb_arr))
                tb_top.Text = Convert.ToString(new_stack.Pop());
            else
                MessageBox.Show("Пустой массив");

        }

        private void bt_create_Click(object sender, EventArgs e)
        {
            if (NoNull(tb_create))
            {
                new_stack = new MyStack<int>(Convert.ToInt32(tb_create.Text));
                tb_arr.Clear();
            }
            else
            {
                MessageBox.Show("Не введено число");
            }
        }
    }
}
