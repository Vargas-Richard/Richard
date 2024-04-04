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
    public partial class Form1 : Form
    {
    





        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

            String username = "Vargas"; 
            String password = "024";
            if ( txtBox1.Text == username && txtBox2.Text == password)
            {
                Form2 newform = new Form2();
                this.Hide();
                newform.Show();
            }

           
        }

        private void Button(object sender, EventArgs e)
        {
         

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
