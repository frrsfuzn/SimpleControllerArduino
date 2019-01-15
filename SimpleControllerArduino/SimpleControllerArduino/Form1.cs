using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SimpleControllerArduino
{
    public partial class Form1 : Form
    {
        private SerialPort myPort;
        public Form1()
        {
            InitializeComponent();
            try {
                myPort = new SerialPort();
                myPort.BaudRate = 9600;
                myPort.PortName = "COM7";
                myPort.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Tidak dapat konek ke Arduino!");
            }
        }

        private void merahOn_Click(object sender, EventArgs e)
        {
            myPort.WriteLine("m1");
        }

        private void merahOff_Click(object sender, EventArgs e)
        {
            myPort.WriteLine("m0");
        }

        private void hijauOn_Click(object sender, EventArgs e)
        {
            myPort.WriteLine("h1");
        }

        private void hijauOff_Click(object sender, EventArgs e)
        {
            myPort.WriteLine("h0");
        }

        private void biruOn_Click(object sender, EventArgs e)
        {
            myPort.WriteLine("b1");
        }

        private void biruOff_Click(object sender, EventArgs e)
        {
            myPort.WriteLine("b0");
        }
    }
}
