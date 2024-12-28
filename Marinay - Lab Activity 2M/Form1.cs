using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marinay___Lab_Activity_2M
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            string date = DateTime.Now.ToLongDateString();
            string time = DateTime.Now.ToLongTimeString();

            ListViewItem item1;

            string check = listBox1.GetItemText(listBox1.SelectedItem);

            listBox1.GetItemText(listBox1.SelectedItem);

            item1 = listView1.Items.Add(check);

            item1.SubItems.Add(time + " " + date);

            //ToUpper
            item1.SubItems.Add(name.ToUpper());


            textBox2.Text = "";

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Log in by typing your name in the format provided, check ONLY ONE in the two, and select ENTER");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Clear();     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form sched = new Form2();
            sched.Show();
            this.Hide(); 
        }

        private void label7_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToLongTimeString();
            label6.Text = DateTime.Now.ToLongDateString();
        }
    }
    
}
