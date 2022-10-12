using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Counter;
            Demo aDemo;
            for (Counter = 0; Counter < 1000; Counter++)
            {
                aDemo = new Demo();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            GC.Collect();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = string.Format($"Сейчас в памяти {0} объектов класса Demo", Demo.Instances);
            label1.Text = string.Format($"Мусор максимально занимает {0} поколения", GC.MaxGeneration + 1);
        }
    }
}
