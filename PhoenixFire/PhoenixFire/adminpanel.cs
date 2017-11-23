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
    public partial class adminpanel : Form
    {
        public adminpanel()
        {
            InitializeComponent();
            textBox1.AppendText(variables.server);
            textBox2.AppendText(variables.port);
            textBox3.AppendText(variables.database);
            textBox4.AppendText(variables.user);
            textBox5.AppendText(variables.pass);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //this.Hide();
            FirstScreen fs = new FirstScreen();
            fs.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            variables.server = textBox1.Text;
            variables.port = textBox2.Text;
            variables.database = textBox3.Text;
            variables.user = textBox4.Text;
            variables.pass = textBox5.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            variables.server = textBox1.Text;
            variables.port = textBox2.Text;
            variables.database = textBox3.Text;
            variables.user = textBox4.Text;
            variables.pass = textBox5.Text;
            String connString = "Server=" + variables.server + ";Port=" + variables.port + ";Database=" + variables.database + ";Uid=" + variables.user + ";password=" + variables.pass + ";";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            try
            {
                conn.Open();
                MessageBox.Show("Connection is Perfect");
            }
            catch
            {
                    MessageBox.Show("Connection Problem. Please check the details of database");
            }
        }

        private void adminpanel_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
