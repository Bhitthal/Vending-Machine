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
    public partial class FirstScreen : Form
    {
        public FirstScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            askrationno ask = new askrationno();
            ask.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminpanel ad = new adminpanel();
            ad.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
