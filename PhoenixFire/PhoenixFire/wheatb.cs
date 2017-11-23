using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhoenixFire
{
    public partial class wheatb : Form
    {
        public wheatb()
        {
            InitializeComponent();
        }

        string[] pur = variables.buy.Split('~');
        string[] q = variables.quota.Split('~');
        private void button1_Click(object sender, EventArgs e)
        {

            if (int.Parse(pur[1]) + 1 + variables.wheatw > int.Parse(q[1]))
            {
                MessageBox.Show("Quota Limit Crossed.You have only allowed to buy maximum " + (int.Parse(q[1]) - int.Parse(pur[1]) - variables.wheatw) + " Wheat");
            }
            else
            {
               // MessageBox.Show("You selected to buy 1 Kg Wheat");
                if (MessageBox.Show("You selected to buy 1 Kg Wheat", "Confirm Your Choice", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBoxButtons.YesNo.Equals("Yes");
                    variables.wheatbuy += 1;
                    this.Dispose();
                    //trying to edit form while running
                    obj123.d.Dispose();
                    obj123.d = new details("123");
                    obj123.d.Show();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.Parse(pur[1]) + 5 + variables.wheatw > int.Parse(q[1]))
            {
                MessageBox.Show("Quota Limit Crossed.You have only allowed to buy maximum " + (int.Parse(q[1]) - int.Parse(pur[1]) - variables.wheatw) + " Wheat");
            }
            else
            {
                if (MessageBox.Show("You selected to buy 5 Kg Wheat", "Confirm Your Choice", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    variables.wheatbuy += 5;
                    this.Dispose();
                    //trying to edit form while running
                    obj123.d.Dispose();
                    obj123.d = new details("123");
                    obj123.d.Show();
                }
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (int.Parse(pur[1]) + 10 + variables.wheatw > int.Parse(q[1]))
            {
                MessageBox.Show("Quota Limit Crossed.You have only allowed to buy maximum " + (int.Parse(q[1]) - int.Parse(pur[1]) - variables.wheatw) + " Wheat");
            }
            else
            {
                if (MessageBox.Show("You selected to buy 10 Kg Wheat", "Confirm Your Choice", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    variables.wheatbuy += 10;
                    this.Dispose();
                    //trying to edit form while running
                    obj123.d.Dispose();
                    obj123.d = new details("123");
                    obj123.d.Show();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (int.Parse(pur[1]) + 20 + variables.wheatw > int.Parse(q[1]))
            {
                MessageBox.Show("Quota Limit Crossed.You have only allowed to buy maximum " + (int.Parse(q[1]) - int.Parse(pur[1]) - variables.wheatw) + " Wheat");
            }
            else
            {
                if (MessageBox.Show("You selected to buy 20 Kg Wheat", "Confirm Your Choice", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    variables.wheatbuy += 20;
                    this.Dispose();
                    //trying to edit form while running
                    obj123.d.Dispose();
                    obj123.d = new details("123");
                    obj123.d.Show();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void wheatb_Load(object sender, EventArgs e)
        {

        }
    }
}
