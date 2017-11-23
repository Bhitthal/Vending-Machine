using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace PhoenixFire
{
    public partial class arduino : Form
    {
        SerialPort port;
        public arduino()
        {
            InitializeComponent();
            //Cursor.Current = Cursors.WaitCursor;
            init();
            if (port.IsOpen)
            {
                port.WriteLine("4");
                for (int i = 0; i < 2000; i++)
                { }
               
                    port.WriteLine("63");
                    
            }
            

        }
        private void init()
        {
            port = new SerialPort();
            port.PortName = "COM7";
            port.BaudRate = 9600;

            try
            {
                port.Open();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }


        }

        private void arduino_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
