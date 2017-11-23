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
    public partial class keroseneb : Form
    {
        public keroseneb()
        {
            InitializeComponent();
        }

        private void keroseneb_Load(object sender, EventArgs e)
        {

        }
        string[] pur = variables.buy.Split('~');
        string[] q = variables.quota.Split('~');
        private void button1_Click_1(object sender, EventArgs e)
        {

            if (int.Parse(pur[2]) + 1 + variables.kerosenew > int.Parse(q[2]))
            {
                MessageBox.Show("Quota Limit Crossed.You have only allowed to buy maximum " + (int.Parse(q[2]) - int.Parse(pur[2]) - variables.kerosenew) + " Wheat");
            }
            else
            {
                if (MessageBox.Show("You selected to buy 1 Lit Kerosene", "Confirm Your Choice", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    variables.kerosenebuy += 1;
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
            if (int.Parse(pur[2]) + 5 + variables.kerosenew > int.Parse(q[2]))
            {
                MessageBox.Show("Quota Limit Crossed.You have only allowed to buy maximum " + (int.Parse(q[2]) - int.Parse(pur[2]) - variables.kerosenew) + " Kerosene");
            }
            else
            {
                if (MessageBox.Show("You selected to buy 5 Lit Kerosene", "Confirm Your Choice", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    variables.kerosenebuy += 5;
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
            if (int.Parse(pur[2]) + 10 + variables.kerosenew > int.Parse(q[2]))
            {
                MessageBox.Show("Quota Limit Crossed.You have only allowed to buy maximum " + (int.Parse(q[2]) - int.Parse(pur[2]) - variables.kerosenew) + " Kerosene");
            }
            else
            {
                if (MessageBox.Show("You selected to buy 10 Lit Kerosene", "Confirm Your Choice", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    variables.kerosenebuy += 10;
                    this.Dispose();
                    //trying to edit form while running
                    obj123.d.Dispose();
                    obj123.d = new details("123");
                    obj123.d.Show();
                }
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(pur[2]) + 20 + variables.kerosenew > int.Parse(q[2]))
            {
                //MessageBox.Show(int.Parse(pur[2]) + "  " + variables.kerosenew + "  " + int.Parse(q[2]));
                MessageBox.Show("Quota Limit Crossed.You have only allowed to buy maximum " + (int.Parse(q[2]) - int.Parse(pur[2]) - variables.kerosenew) + " Kerosene");
            }
            else
            {
                //MessageBox.Show(int.Parse(pur[2]) + "  " + variables.kerosenew + "  " + int.Parse(q[2]));
                //MessageBox.Show(int.Parse(pur[2])+" + 20 >" +int.Parse(q[2]));
                if (MessageBox.Show("You selected to buy 20 Lit Kerosene", "Confirm Your Choice", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                    variables.kerosenebuy += 20;
                    this.Dispose();
                    //trying to edit form while running
                    obj123.d.Dispose();
                    obj123.d = new details("123");
                    obj123.d.Show();
                }
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
