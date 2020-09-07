using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text.Length.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = textBox1.Text;

            char[] separator = {' '};
            int wordsCount = txt.Split(separator, StringSplitOptions.RemoveEmptyEntries).Length;

            MessageBox.Show(wordsCount.ToString());
        }
    }
}
