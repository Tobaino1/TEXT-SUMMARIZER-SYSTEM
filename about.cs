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

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            home_summary myform = new home_summary();
            myform.Show();
            this.Hide();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            browser myform = new browser();
            myform.Show();
            this.Hide();

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            browser myform = new browser();
            myform.Show();
            this.Hide();
        }
    }
}
