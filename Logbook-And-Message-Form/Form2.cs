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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string receiver = "To: ";
            string send = "From: ";
            string exactTime = DateTime.Now.ToLongTimeString();
            string exactDate = DateTime.Now.ToLongDateString();
            string message = textBoxMessage.Text;
            //Length
            string outputChar = message.Length + " characters and ";
            //Insert 
            string ID = textBoxID.Text.Insert(0, "#");
            //ToString
            int num = 0;
            num.ToString(); 

            labelOutput.Text = ID + num + "\n" + receiver + textBoxTo.Text + "\n" + send + textBoxSent.Text + "\n" +
            "\n" + textBoxMessage.Text + "\n ";

            labelUp.Text = exactDate + "\n" + exactTime;

            System.Text.RegularExpressions.MatchCollection wordCount =
                System.Text.RegularExpressions.Regex.Matches(message, @"[\S]+");

            outputChar += wordCount.Count.ToString() + " words count";

            labelWords.Text = outputChar;

            //Substring

            string sub = message.Substring(0, 10); 
            labelSub.Text = sub.Insert(10, "..."); 




        }

        private void labelOutput_Click(object sender, EventArgs e)
        {
        }

        private void buttontTextColorChange_Click(object sender, EventArgs e)
        {
            ColorDialog colorChange = new ColorDialog();
            colorChange.AllowFullOpen = false;
            colorChange.Color = labelID.ForeColor;
            if (colorChange.ShowDialog() == DialogResult.OK)
            {
                labelID.ForeColor = colorChange.Color;
                labelSent.ForeColor = colorChange.Color;
                labelTo.ForeColor = colorChange.Color;
                labelWrite.ForeColor = colorChange.Color;
            }
        }

        private void buttonDisable_Click(object sender, EventArgs e)
        {
            buttontTextColorChange.Enabled = false; 
        }

        private void buttonEnable_Click(object sender, EventArgs e)
        {
            buttontTextColorChange.Enabled = true; 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxSent.Clear();
            textBoxTo.Clear();
            textBoxMessage.Clear();        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form back = new Form1();
            back.Show();
            this.Hide(); 
        }
    }
}
