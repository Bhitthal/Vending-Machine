using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace PhoenixFire
{
    public partial class personaldetails : Form 
    {
        private string str;// {get ; set ;}

        public personaldetails()
        {
            //InitializeComponent();

            
        }
        private void peonaldetails_Load(object sender, EventArgs e)
        {

        }

        public personaldetails(string str)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.str = str;
           // textBox1.AppendText(str);
            string[] t = str.Split('~');
            textBox1.AppendText(t[0]);
            textBox7.AppendText(t[1]);
            textBox6.AppendText(t[2]);
            textBox5.AppendText(t[3]);
            textBox3.AppendText(t[4]);
            textBox4.AppendText(t[5]);
         

        }

       
    

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            askrationno ask = new askrationno();
            ask.Show();
            this.Dispose();
        }

        private void personaldetails_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            obj123.d = new details(); 
            obj123.d.Show();
            this.Hide();
            
        }
    }
}
