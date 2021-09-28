using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gün_saat_sipariş_girme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             listBox1.Items.Add(dateTimePicker1.Text + " -- " + dateTimePicker2.Text + " -- " + textBox1.Text);
            listBox1.Items.Add("----------------------------------------------------------"); 
            textBox1.Clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*listBox1.Items.Remove(listBox1.SelectedItem);*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            dateTimePicker2.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             
            dateTimePicker2.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
