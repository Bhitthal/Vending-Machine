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
    public partial class confirm_page : Form
    {
        public confirm_page()
        {
            InitializeComponent();
            string tt = variables.buy;
            string[] pur = tt.Split('~');
        }

        public confirm_page(int r , int w , int k)
        {
            InitializeComponent();
            textBox1.Text = "Rs. " + (r + w + k);
            string tt = variables.buy;
            string[] pur = tt.Split('~');
           
            

        }

        private void confirm_page_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure that you want this as your Final Order","Confrim Pay", MessageBoxButtons.OKCancel) ==  DialogResult.OK )
            {
                MessageBox.Show("Account Tranfer has been Made");
                //Update Database
                string tt = variables.buy;
                string[] pur = tt.Split('~');
                String connString = "Server=" + variables.server + ";Port=" + variables.port + ";Database=" + variables.database + ";Uid=" + variables.user + ";password=" + variables.pass + ";";
                MySqlConnection conn = new MySqlConnection(connString);
                MySqlCommand command = conn.CreateCommand();
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Problem. Please check the details of database");
                }
                //update query
               // MessageBox.Show(variables.ricebuy +" "+ pur[0]);
                command.CommandText = " UPDATE `ration`.`cardholder_details` SET `rice` = '" +( variables.ricebuy + int.Parse(pur[0]) )+ "' WHERE `cardholder_details`.`Ration_Number` = '" + variables.rationno+ "'; ";
                MySqlDataReader reader = command.ExecuteReader();
                reader.Close();
                command.CommandText = " UPDATE `ration`.`cardholder_details` SET `wheat` = '" + (variables.wheatbuy + int.Parse(pur[1])) + "' WHERE `cardholder_details`.`Ration_Number` = '" + variables.rationno + "'; ";
               reader = command.ExecuteReader();
                reader.Close();
                command.CommandText = " UPDATE `ration`.`cardholder_details` SET `kerosene` = '" + (variables.kerosenebuy + int.Parse(pur[2])) + "' WHERE `cardholder_details`.`Ration_Number` = '" + variables.rationno + "'; ";
                 reader = command.ExecuteReader();
                reader.Close();
                arduino a = new arduino();
                a.Show();
                this.Dispose();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            obj123.d.Show();
            this.Dispose();
        }

        private void confirm_page_Load_1(object sender, EventArgs e)
        {

        }

    }
}
