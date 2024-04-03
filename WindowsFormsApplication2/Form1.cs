using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
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




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn1.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn9.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn2.Text;
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

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn8.Text;
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn11.Text;
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn12.Text;
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn13.Text;
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn14.Text;
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn15.Text;
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn16.Text;
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn17.Text;
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn18.Text;
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn19.Text;
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn20.Text;
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();

        }

        private void btnMinus_Click(object sender, EventArgs e)
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

        private void btnDivi_Click(object sender, EventArgs e)
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTotall.Clear();
            txtTotal.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }
    }
}
