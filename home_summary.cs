using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenTextSummarizer;

namespace OTSApp
{
    public partial class home_summary : Form
    {
        public home_summary()
        {
            InitializeComponent();
        }

        private void SummarizeButton_Click(object sender, EventArgs e)
        {
            int sentCount = 1;
            int.TryParse(numericUpDown1.Text, out sentCount);
            SummarizerArguments sumargs = new SummarizerArguments
                                              {
                                                  DictionaryLanguage = "en",
                                                  DisplayLines = sentCount,
                                                  DisplayPercent = 0,
                                                  InputFile = "",
                                                  InputString = OriginalTextBox.Text
                                              };
            SummarizedDocument doc = Summarizer.Summarize(sumargs);
            string summary = string.Join("\r\n\r\n", doc.Sentences.ToArray());
            SummaryTextBox.Text = summary;

        }

        private void OriginalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            browser myform = new browser();
            myform.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OriginalTextBox.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SummaryTextBox.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SentenceCountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
              about myform = new about();
            myform.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            home_summary myform = new home_summary();
            myform.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
