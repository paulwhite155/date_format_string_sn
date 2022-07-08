using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace date_format_string
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.textBox2.Text = DateTime.Now.ToString("HH:mm:ss");
            this.label3.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label3.Text = DateTime.Now.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Int64 i;
            Int64.TryParse(this.textBox3.Text, out i);
            this.textBox4.Text = i.ToString("#,#");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Int64 i;
            bool b;
            b = Int64.TryParse(textBox5.Text, out i);
            if (b == true)
                {
                MessageBox.Show("it is a number ...");
                }
            else
            {
                MessageBox.Show("nope not a number");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("are you sure?", "alert", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                this.Close();
            }
            
        }
    }
}
