using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public MyQueue<int> new_queue;
        public int[] mas;
        int size;
        private bool NoNull(TextBox tb)
        {
            bool flag = false;
            for (int i = 0; i < tb.TextLength;i++)
            {
                if (Char.IsDigit(tb.Text[i]))
                {
                    flag = true;
                }
                else 
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        private void bt_create_Click(object sender, EventArgs e)
        {
            if (NoNull(tb_create))
            {
                size = Convert.ToInt32(tb_create.Text);
                new_queue = new MyQueue<int>(size);
                tb_create.Text = "";
                queue.Items.Clear();
            }
            else
            {
                MessageBox.Show("Не корректное число");
            }
        }

        private void bt_enqueue_Click(object sender, EventArgs e)
        {
            if (NoNull(tb_enqueue))
            {
                if (queue.Items.Count < size)
                {
                    new_queue.Enqueue(Convert.ToInt32(tb_enqueue.Text));
                    tb_enqueue.Text = "";
                    this.print_queue();
                }
                else
                {
                    MessageBox.Show("Массив переполнен");
                }
            }
            else
            {
                MessageBox.Show("Не корректное число");
            }

        }

        private void bt_dequeue_Click(object sender, EventArgs e)
        {
            if (queue.Items.Count != 0)
            {
                tb_dequeue.Text = Convert.ToString(new_queue.Dequeue());
                this.print_queue();
            }
            else
            {
                MessageBox.Show("Массив пуст");
            }

        }

        private void bt_peek_Click(object sender, EventArgs e)
        {
            if (queue.Items.Count != 0)
            {
                tb_peek.Text = Convert.ToString(new_queue.Peek());
            }
            else
            {
                MessageBox.Show("Массив пуст");
            }
            
        }
        private void print_queue()
        {
            mas = new_queue.ToArray();
            queue.Items.Clear();
            for (int i = 0; i < mas.Length; i++)
            {
                queue.Items.Insert(i, mas[i]);
            }
        }
    }
}
