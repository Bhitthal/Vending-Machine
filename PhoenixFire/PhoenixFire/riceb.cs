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
    public partial class riceb : Form
    {
        public riceb()
        {
            InitializeComponent();
            
        }
        string[] pur = variables.buy.Split('~');
        string[] q = variables.quota.Split('~');
        private void button1_Click(object sender, EventArgs e)
        {

            if (int.Parse(pur[0]) + 1 + variables.ricew > int.Parse(q[0]))
            {
                MessageBox.Show("Quota Limit Crossed.You have only allowed to buy maximum " + (int.Parse(q[0]) - int.Parse(pur[0]) - variables.ricew) + " rice");
            }
            else
            {
                if (MessageBox.Show("You selected to buy 1 Kg Rice", "Confirm Your Choice", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    variables.ricebuy += 1;
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
            if (int.Parse(pur[0]) + 5 + variables.ricew > int.Parse(q[0]))
            {
                MessageBox.Show("Quota Limit Crossed.You have only allowed to buy maximum " + (int.Parse(q[0]) - int.Parse(pur[0]) - variables.ricew) + " rice");
            }
            else
            {
                if (MessageBox.Show("You selected to buy 5 Kg Rice", "Confirm Your Choice", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    variables.ricebuy += 5;
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
            if (int.Parse(pur[0]) + 10 + variables.ricew > int.Parse(q[0]))
            {
                MessageBox.Show("Quota Limit Crossed.You have only allowed to buy maximum " + (int.Parse(q[0]) - int.Parse(pur[0]) - variables.ricew) + " rice");
            }
            else
            {
                if (MessageBox.Show("You selected to buy 10 Kg Rice", "Confirm Your Choice", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    variables.ricebuy += 10;
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
            if (int.Parse(pur[0]) + 20 + variables.ricew > int.Parse(q[0]))
            {
                MessageBox.Show("Quota Limit Crossed.You have only allowed to buy maximum " + (int.Parse(q[0]) - int.Parse(pur[0]) - variables.ricew) + " rice");
            }
            else
            {
                if (MessageBox.Show("You selected to buy 20 Kg Rice", "Confirm Your Choice", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    variables.ricebuy += 20;
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

        private void riceb_Load(object sender, EventArgs e)
        {

        }
    }
}
