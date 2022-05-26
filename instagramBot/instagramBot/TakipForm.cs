using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading;

namespace instagramBot
{
    public partial class TakipForm : Form
    {
        public TakipForm()
        {
            InitializeComponent();
        }


        private void btnTakip_Click(object sender, EventArgs e)
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.instagram.com");
            Thread.Sleep(5000);




            IWebElement kullaniciAdi = driver.FindElement(By.Name("username"));
            IWebElement sifre = driver.FindElement(By.Name("password"));
            IWebElement girisBtn = driver.FindElement(By.CssSelector(".sqdOP.L3NKy.y3zKF"));

            kullaniciAdi.SendKeys(Form1.kadi);
            sifre.SendKeys(Form1.sifre);
            girisBtn.Click();
            Thread.Sleep(8000);


            driver.Navigate().GoToUrl("https://www.instagram.com/explore/tags/" + textBox1.Text);
            Thread.Sleep(4000);


            IWebElement gonderi = driver.FindElement(By.CssSelector(".v1Nh3.kIKUG._bz0w"));
            gonderi.Click();
            Thread.Sleep(3500);

            IWebElement hsp = driver.FindElement(By.CssSelector(".sqdOP.yWX7d._8A5w5.ZIAjV"));
            hsp.Click();
            Thread.Sleep(3500);

            IWebElement flw = driver.FindElement(By.XPath("/html/body/div[1]/section/main/div/header/section/ul/li[2]/a/div/span"));
            flw.Click();
            Thread.Sleep(2500);

            //Scroll Kaydırma komutları

            for (int i = 0; i < 4; i++)
            {
                string jsCommand = "" +
                    "sayfa = document.querySelector('.isgrP');" +
                    "sayfa.scrollTo(0,400);";

                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                var sayfaSonu = Convert.ToInt32(js.ExecuteScript(jsCommand));
                Thread.Sleep(4000);

            }

            for (int i = 0; i < 4; i++)
            {
                string jsCommand = "" +
                    "sayfa = document.querySelector('.isgrP');" +
                    "sayfa.scrollTo(0,-400);";

                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                var sayfaSonu = Convert.ToInt32(js.ExecuteScript(jsCommand));
                Thread.Sleep(4000);

            }



            //Scroll Kaydırma komutları


            // Takip etme komutları

            var takipcilerr = driver.FindElement(By.TagName("body")).FindElements(By.TagName("ul"));
            Thread.Sleep(3000);
            var butonlarr = takipcilerr[2].FindElements(By.TagName("button"));
            for (int i = 0; i < 49; i++)
            {

                Thread.Sleep(2000);
                butonlarr[i].Click();
            

            }

            // Takip etme komutları
           
              










        }
    }
}
