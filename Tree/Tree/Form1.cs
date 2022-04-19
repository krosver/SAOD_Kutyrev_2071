using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MyTree Tree = new MyTree();
        private void bt_add_Click(object sender, EventArgs e)
        {
            Tree.add(Convert.ToInt32(tb_add.Text));
            tb_add.Clear();
        }

        private void bt_find_Click(object sender, EventArgs e)
        {
            Tree.find(Convert.ToInt32(tb_find.Text));
        }

        private void bt_tree_Click(object sender, EventArgs e)
        {
            Tree.CLR(Tree.Root);
            Form_tree form = new Form_tree(Tree.list);
            form.Show();
        }

        private void bt_del_Click(object sender, EventArgs e)
        {
            Tree.delete(Convert.ToInt32(tb_del.Text));
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tree.CLR(Tree.Root);
        }
    }
}
