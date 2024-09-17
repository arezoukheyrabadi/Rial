using Rial.Service;
using System.Diagnostics;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;



namespace Rial
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UserControl1 myuser = new UserControl1();
            panel2.Controls.Clear();
            panel2.Controls.Add(myuser);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }



}


   

