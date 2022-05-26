using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace instagramBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string kadi;
        public static string sifre;
        

        private void button1_Click(object sender, EventArgs e)
        {
            kadi = txtKadi.Text;
            sifre = txtSifre.Text;

            new Anasayfa().Show();
            this.Hide();


            

            

             
           




        }
    }
}
