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
    public partial class details : Form
    {
        int r , w , k;
        public details()
        {
            InitializeComponent();
            String connString = "Server=" + variables.server + ";Port=" + variables.port + ";Database=" + variables.database + ";Uid=" + variables.user + ";password=" + variables.pass + ";";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();

            // FEtching consumed quantities of user
            string tt = variables.buy;
            string[] pur = tt.Split('~');
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Problem. Please check the details of database");
            }

            // FOR RICE
            command.CommandText = " Select  * from items where item = 'rice'";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBox4.Text = reader.GetInt16("Quota").ToString();
                textBox5.Text = pur[0];
                textBox6.Text = reader.GetString(reader.GetOrdinal("Unit"));
                textBox7.Text = reader.GetInt16("Price").ToString();
                variables.quota += textBox4.Text + "~";
            }
            textBox3.Text ="" + (variables.ricebuy);
            r = int.Parse(textBox3.Text) * int.Parse(textBox7.Text);
            textBox22.Text = "Rs. " + (r);
            reader.Close();
            // FOR Wheat
            command.CommandText = " Select  * from items where item = 'wheat'";
            MySqlDataReader reader1 = command.ExecuteReader();
            if (reader1.Read())
            {
                textBox9.Text = reader1.GetInt16("Quota").ToString();
                textBox10.Text = pur[1];
                textBox11.Text = reader1.GetString(reader1.GetOrdinal("Unit"));
                textBox12.Text = reader1.GetInt16("Price").ToString();
                variables.quota += textBox9.Text + "~";
            }
            textBox18.Text = "" + variables.wheatbuy;
            w = int.Parse(textBox18.Text) * int.Parse(textBox12.Text);
            textBox21.Text = "Rs. " +  (w); 
            reader1.Close();
            // FOR Kesoscen
            command.CommandText = " Select  * from items where item = 'kerosene'";
            MySqlDataReader reader2 = command.ExecuteReader();
            if (reader2.Read())
            {
                textBox14.Text = reader2.GetInt16("Quota").ToString();
                textBox15.Text = pur[2];
                textBox16.Text = reader2.GetString(reader2.GetOrdinal("Unit"));
                textBox17.Text = reader2.GetInt16("Price").ToString();
                variables.quota += textBox14.Text;
            }
            textBox20.Text = "" + variables.kerosenebuy;
            k = int.Parse(textBox17.Text) * int.Parse(textBox20.Text);
            textBox23.Text = "Rs. " + (k);
            reader2.Close();

            textBox19.Text = "Rs. " + (r+k+w); 
            textBox2.Text = variables.uname;
            textBox1.Text = variables.rationno;
            //conn.Close();
        }
        // to change name to button
        public details(String str)
        {
            InitializeComponent();
            // new name to button
            button2.Text = "Click to Buy More";
            //MessageBox.Show("sdfdsf");   to verify working of constructor

            String connString = "Server=" + variables.server + ";Port=" + variables.port + ";Database=" + variables.database + ";Uid=" + variables.user + ";password=" + variables.pass + ";";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();

            // FEtching consumed quantities of user
            string tt = variables.buy;
            string[] pur = tt.Split('~');
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Problem. Please check the details of database");
            }

            

            // FOR RICE
            command.CommandText = " Select  * from items where item = 'rice'";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBox4.Text = reader.GetInt16("Quota").ToString();
                textBox5.Text = pur[0];
                textBox6.Text = reader.GetString(reader.GetOrdinal("Unit"));
                textBox7.Text = reader.GetInt16("Price").ToString();
               // variables.quota += textBox4.Text + "~";
            }
            textBox3.Text = "" + variables.ricebuy;
            r = int.Parse(textBox3.Text) * int.Parse(textBox7.Text);
            textBox22.Text = "Rs. " + (r);
            reader.Close();
            // FOR Wheat
            command.CommandText = " Select  * from items where item = 'wheat'";
            MySqlDataReader reader1 = command.ExecuteReader();
            if (reader1.Read())
            {
                textBox9.Text = reader1.GetInt16("Quota").ToString();
                textBox10.Text = pur[1];
                textBox11.Text = reader1.GetString(reader1.GetOrdinal("Unit"));
                textBox12.Text = reader1.GetInt16("Price").ToString();
                //variables.quota += textBox9.Text + "~";
            }
            textBox18.Text = "" + variables.wheatbuy;
            w = int.Parse(textBox18.Text) * int.Parse(textBox12.Text);
            textBox21.Text = "Rs. " + (w);
            reader1.Close();
            // FOR Kesoscen
            command.CommandText = " Select  * from items where item = 'kerosene'";
            MySqlDataReader reader2 = command.ExecuteReader();
            if (reader2.Read())
            {
                textBox14.Text = reader2.GetInt16("Quota").ToString();
                textBox15.Text = pur[2];
                textBox16.Text = reader2.GetString(reader2.GetOrdinal("Unit"));
                textBox17.Text = reader2.GetInt16("Price").ToString();
                //variables.quota += textBox14.Text;
            }
            textBox20.Text = "" + variables.kerosenebuy;
            k = int.Parse(textBox17.Text) * int.Parse(textBox20.Text);
            textBox23.Text = "Rs. " + (k);
            reader2.Close();

            textBox19.Text = "Rs. " + (r + k + w);
            textBox2.Text = variables.uname;
            textBox1.Text = variables.rationno;
            //conn.Close();
            //estimating the weights purchased from purchase textboxes
            variables.ricew = int.Parse(textBox3.Text);
            variables.wheatw = int.Parse(textBox18.Text);
            variables.kerosenew = int.Parse(textBox20.Text);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void details_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //personaldetails pn = new personaldetails();
            askrationno pn = new askrationno();
            pn.Show();
            this.Dispose();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            buybutton buy = new buybutton();
            buy.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((r + w + k) > 0)
            {
                confirm_page cp = new confirm_page(r, w, k);
                this.Hide();
                cp.Show();
            }
            else
                MessageBox.Show("You dont have selected anythink");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //wheat -
            if (int.Parse(textBox18.Text) - 1 < 0)
            {
                MessageBox.Show("Cann't give us something :P");
            }
            else
            {
                variables.wheatbuy -= 1;
                textBox18.Text = "" + variables.wheatbuy;
                w = int.Parse(textBox18.Text) * int.Parse(textBox12.Text);
                textBox21.Text = "Rs. " + (w);
                textBox19.Text = "Rs. " + (r + k + w);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //rice -
            if (int.Parse(textBox3.Text) - 1 < 0)
            {
                MessageBox.Show("Cann't give us something :P");
            }
            else
            {
                variables.ricebuy -= 1;
                textBox3.Text = "" + (variables.ricebuy);
                r = int.Parse(textBox3.Text) * int.Parse(textBox7.Text);
                textBox22.Text = "Rs. " + (r);
                textBox19.Text = "Rs. " + (r + k + w);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //wheat +
            if (int.Parse(textBox18.Text) + int.Parse(textBox10.Text) + 1 > int.Parse(textBox9.Text))
                MessageBox.Show("LIMIT CROSSES");
            else
            {
                variables.wheatbuy += 1;
                textBox18.Text = "" + variables.wheatbuy;
                w = int.Parse(textBox18.Text) * int.Parse(textBox12.Text);
                textBox21.Text = "Rs. " + (w);
                textBox19.Text = "Rs. " + (r + k + w);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //kero +
            if (int.Parse(textBox20.Text) + int.Parse(textBox15.Text) + 1 > int.Parse(textBox14.Text))
                MessageBox.Show("LIMIT CROSSES");
            else
            {
                variables.kerosenebuy += 1;
                textBox20.Text = "" + variables.kerosenebuy;
                k = int.Parse(textBox17.Text) * int.Parse(textBox20.Text);
                textBox23.Text = "Rs. " + (k);
                textBox19.Text = "Rs. " + (r + k + w);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //kero -
            if (int.Parse(textBox20.Text) - 1 < 0)
            {
                MessageBox.Show("Cann't give us something :P");
            }
            else
            {
                variables.kerosenebuy -= 1;
                textBox20.Text = "" + variables.kerosenebuy;
                k = int.Parse(textBox17.Text) * int.Parse(textBox20.Text);
                textBox23.Text = "Rs. " + (k);
                textBox19.Text = "Rs. " + (r + k + w);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //rice +
            if (int.Parse(textBox3.Text) + int.Parse(textBox5.Text) + 1 > int.Parse(textBox4.Text))
                MessageBox.Show("LIMIT CROSSES");
            else
            {
                variables.ricebuy += 1;
                textBox3.Text = "" + (variables.ricebuy);
                r = int.Parse(textBox3.Text) * int.Parse(textBox7.Text);
                textBox22.Text = "Rs. " + (r);
                textBox19.Text = "Rs. " + (r + k + w);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

   

    }
}
