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

    public partial class Form1 : Form
    {
        SerialPort port;
        public Form1()
        {
            InitializeComponent();
            ini();
            String rice, wheat, kerosene="2";
          //  port.WriteLine("i");
          //  port.DiscardOutBuffer();
          //  ini();
       //  for (int iii = 0; iii < 2503; iii++) ;
        //        port.WriteLine(kerosene);

            String sss="";
            sss = port.ReadLine();
           MessageBox.Show(sss);
           /*MessageBox.Show("mcbgjdshjlvfdjkl");
            while (port.ReadLine() == ""+kerosene)
            {
                //MessageBox.Show("Please Insert A Container");
            }
            MessageBox.Show(sss);
            MessageBox.Show("mcbgjdshjlvfdjkl");
            while (port.ReadLine() == "n")
            {
                MessageBox.Show("Please Insert A Container");
                
            }
            if (port.ReadLine() == "o")
                MessageBox.Show("Complete");*/
        }

        private void ini()
        {
            port = new SerialPort();
            port.PortName = "COM7";
            port.BaudRate = 9600;
            try
            {
                port.Open();

            }
            catch (Exception e)
            {
                MessageBox.Show("Hardware Problem. Microprosessor ERROR #$456%&");
            }
        }
            
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void data_tb_TextChanged(object sender, EventArgs e)
        {
            String ax = port.ReadLine();
            data_tb.Text = ax;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            port.WriteLine(data_tb.Text);
            data_tb.Text = "";
        }
    }
}
