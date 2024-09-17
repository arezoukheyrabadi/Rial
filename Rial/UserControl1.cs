using Rial.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rial
{
   
    public partial class UserControl1 : UserControl
    {
        toStringService tostringService = new toStringService();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            label1.Text = x.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            textBox2.Text = long.Parse(textBox1.Text.Replace(",", "")).ToString("n0");
            textBox3.Text = tostringService.num2rial(textBox1.Text);

            textBox4.Text = tostringService.num2Toman(textBox1.Text);

        }
    }
}
