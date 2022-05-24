using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public MyOPZ new_opz;
        string[] arr_formula;
        private void bt_start_Click(object sender, EventArgs e)
        {
            tb_opz.Clear();
            new_opz = new MyOPZ(tb_formula.Text);
            arr_formula = new string[tb_formula.Text.Length];
            add_formula(tb_formula.Text);
            arr_formula = new_opz.ToOPZ();
            foreach (string i in arr_formula)
            {
                tb_opz.Text += i;
                tb_opz.Text += " ";
            }
            
            tb_answer.Text = new_opz.Answer();
        }

        private void add_formula(string formula)
        {
            string number = "";
            foreach (char i in formula)
            {
                if (Char.IsNumber(i))
                {
                    number += i;
                }
                else
                {
                    if (number != "")
                    {
                        new_opz.addStack(number);
                        number = "";
                    }
                    new_opz.addStack(Convert.ToString(i));
                }
            }
            if (number != "")
            {
                new_opz.addStack(number);
            }
        }

        private void tb_formula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
