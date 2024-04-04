using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vargas_Richard
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void btnOne_Click(object sender, EventArgs e)
        {


            int nam1, nam2, nam3, nam4, nam5, nam6, nam7, nam8, nam9, total;

            nam1 = 0;
            nam2 = 0;
            nam3 = 0;
            nam4 = 0;
            nam5 = 0;
            nam6 = 0;
            nam7 = 0;
            nam8 = 0;
            nam9 = 0;

            if (checkBox1.Checked)
            {
                nam1 = 100;
            }
            if (checkBox2.Checked)
            {
                nam2 = 250;
            }
            if (checkBox3.Checked)
            {
                nam3 = 200;
            }
            if (checkBox4.Checked)
            {
                nam4 = 70;
            }
            if (checkBox5.Checked)
            {
                nam5 = 300;
            }
            if (checkBox6.Checked)
            {
                nam6 = 80;
            }
            if (checkBox7.Checked)
            {
                nam7 = 3000;
            }
            if (checkBox8.Checked)
            {
                nam8 = 5000;
            }
            if (checkBox9.Checked)
            {
                nam9 = 10000;
            }


            total = nam1 + nam2 + nam3 + nam4 + nam5 + nam6 + nam7 + nam8 + nam9;

            txtBox1.Text = total.ToString();
























        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtBox1.Clear();
            
        }
    }
}
