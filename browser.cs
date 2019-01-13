using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OTSApp
{
    public partial class browser : Form
    {
        public browser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string WebPage = txtAddress.Text.Trim();
            webBrowser1.Navigate(WebPage);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            home_summary form = new home_summary();
            this.Hide();
            form.Show();
            // i want to go back to form1
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
     
        bool lr = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lr)
            {

                label2.Location = new Point(label2.Location.X + 5, label2.Location.Y);

            }
            else
            {
                label2.Location = new Point(label2.Location.X - 5, label2.Location.Y);
            }
            if (label2.Location.X + label2.Width >= this.Width)
            {
                lr = false;
            }
            if (label2.Location.X <= 0)
            {
                lr = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           about myform = new about();
            myform.Show();
            this.Hide();
        }
    }
}
