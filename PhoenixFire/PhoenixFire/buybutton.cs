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
    public partial class buybutton : Form
    {
        public buybutton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            riceb r = new riceb();
            r.Show();
            //this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wheatb w = new wheatb();
            w.Show();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            keroseneb k = new keroseneb();
            k.Show();
            //this.Dispose();
        }

        private void buybutton_Load(object sender, EventArgs e)
        {

        }

        
    }
}
