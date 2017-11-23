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
    public partial class askrationno : Form
    {
        public askrationno()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
         //   personaldetails pd = new personaldetails();
          //  pd.Show(); 
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            
            variables.rationno = textBox1.Text;
            //this.Hide();
            String connString = "Server="+ variables.server +";Port="+variables.port+";Database="+variables.database+";Uid="+variables.user+";password="+variables.pass+";";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = " Select  * from cardholder_details where Ration_Number = '" + variables.rationno + "' ";
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Problem. Please check the details of database");
                FirstScreen fs = new FirstScreen();
                fs.Show();
                this.Dispose();
            }
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {

                String temp = variables.rationno + "~" + reader.GetString(reader.GetOrdinal("Card_holder_name")) + "~" + reader.GetString(reader.GetOrdinal("Address")) + "~" +
                    reader.GetInt32("Phone_number").ToString() + "~" + reader.GetInt16("Family_Size").ToString() + "~"+ reader.GetString(reader.GetOrdinal("Category"));
                variables.buy = reader.GetInt16("rice").ToString() + "~" + reader.GetInt16("wheat").ToString() + "~" + reader.GetInt16("kerosene").ToString();
                variables.uname = reader.GetString(reader.GetOrdinal("Card_holder_name"));
                personaldetails pd = new personaldetails(temp);
                pd.Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("Invalid Ration Card Number");

              //  this.Show();
            }
            
            
            
             

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            FirstScreen fs = new FirstScreen();
            fs.Show();
            this.Dispose();
        }

        private void askrationno_Load(object sender, EventArgs e)
        {

        }
    }
}
