using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Register
{
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index1 = comboBox1.SelectedIndex;
            //Total.Text = ("Hello");
            //Fix the line below to calculate the following
            Total.Text = "£" + textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void payment_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private TextBox GetTextBox1()
        {
            return textBox1;
        }

        private void costBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Total_Click(object sender, EventArgs e)
        {
 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
