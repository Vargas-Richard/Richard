using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Caltotal;
        int num1;
        int num2;
        string option;
        int result;


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn1.Text;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btn11_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn11.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn6.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            txtTotall.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
        
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtTotal.Text);

            if (option.Equals("+"))
                result = num1 + num2;

            if (option.Equals("-"))
                result = num1 - num2;

            if (option.Equals("*"))
                result = num1 * num2;

            if (option.Equals("/"))
                result = num1 / num2;

            txtTotall.Text = result + "";
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn111.Text;
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn22.Text;
        }

        private void btn33_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn33.Text;
        }

        private void btn44_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn44.Text;
        }

        private void btn55_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn55.Text;
        }

        private void btn66_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn66.Text;
        }

        private void btn77_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn77.Text;
        }

        private void btn88_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn88.Text;
        }

        private void btn99_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn99.Text;
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn00.Text;
        }
    }
}
