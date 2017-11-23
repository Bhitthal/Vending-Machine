using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form2 : Form
    {
        SerialPort port;
        public Form2()
        {
            InitializeComponent();
            port = new SerialPort();
            port.PortName = "COM3";
            port.BaudRate = 9600;
            String rice="11", wheat, kerosene = "2";
            try
            {
                port.Open();
            

            }
            catch (Exception e)
            {
                MessageBox.Show("Hardware Problem. Microprosessor ERROR #$456%&");
            }
            for (int ii = 0; ii < 1000000000; ii++)
            {
            }
            port.WriteLine("a");
            for (int ii = 0; ii < 1000000000; ii++)
            {
            }
            
            port.WriteLine(rice);
            while (true)
            {
                //MessageBox.Show("sdasd");
                //MessageBox.Show("s"+port.ReadChar()+"l");
                //AboutBox1 ab = new AboutBox1();
                int t = (int)(port.ReadChar());
                if(t==110)
                {
                    MessageBox.Show("Please Insert A Container");
                    //ab.Show();
                }
                //MessageBox.Show("mcbgjdshjlvfdjkl");
                if (t==109)
                {
                    //MessageBox.Show("  Container");
                    //ab.Dispose();
                }
                if (t == 111)
                {
                    MessageBox.Show("Complete");
                   // port.Close();
                    
                    //this.Close();
                    break;
                }
            }


            //KEroscean dispatch
            if (kerosene != "0")
            {

                MessageBox.Show("Do you want to start dispatching k");
                for (int ii = 0; ii < 1000000000; ii++)
                {
                }
                port.WriteLine("i");
                for (int ii = 0; ii < 1000000000; ii++)
                {
                }

                port.WriteLine(kerosene);
                while (true)
                {
                    //MessageBox.Show("sdasd");
                    //MessageBox.Show("s"+port.ReadChar()+"l");
                    //AboutBox1 ab = new AboutBox1();
                    int t = (int)(port.ReadChar());
                    if (t == 110)
                    {
                        MessageBox.Show("Please Insert A Container");
                        //ab.Show();
                    }
                    //MessageBox.Show("mcbgjdshjlvfdjkl");
                    if (t == 109)
                    {
                        //MessageBox.Show("  Container");
                        //ab.Dispose();
                    }
                    if (t == 111)
                    {
                        MessageBox.Show("Complete");
                       // port.Close();

                       // this.Close();
                        //break;
                    }
                }
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            port.WriteLine(textBox1.Text);
            textBox1.Text = "";
        }
    }
}
