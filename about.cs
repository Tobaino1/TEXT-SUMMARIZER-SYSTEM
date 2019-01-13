using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OTSApp
{
    public partial class about : OTSApp.browser
    {
        public about()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            home_summary myform = new home_summary();
            myform.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            browser myform = new browser();
            myform.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            browser myform = new browser();
            myform.Show();
            this.Hide();
        }
    }
}
