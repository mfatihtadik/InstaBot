using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace instagramBot
{
    public partial class MesajForm : Form
    {
        public MesajForm()
        {
            InitializeComponent();
        }

        private void btnTMesajAt_Click(object sender, EventArgs e)
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

            //Dm mesaj yerine git.

            driver.Navigate().GoToUrl("https://www.instagram.com/direct/inbox/");
            Thread.Sleep(4000);

            //bildirim mesajını kapat

            IWebElement htmsj = driver.FindElement(By.XPath("/html/body/div[5]/div/div/div/div[3]/button[2]"));
            htmsj.Click();
            Thread.Sleep(2000);

            //ilk mesaj gönder butonu

            IWebElement msjgndr = driver.FindElement(By.XPath("/html/body/div[1]/section/div/div[2]/div/div/div[2]/div/div[3]/div/button"));
            msjgndr.Click();
            Thread.Sleep(2500);

            


            for (int i = 0; i < 20; i++)
            {
                //alıcı kullanıcı adı yazm.

                IWebElement mkadi = driver.FindElement(By.XPath("html/body/div[6]/div/div/div[2]/div[1]/div/div[2]/input"));
                mkadi.SendKeys(richTextBox2.Lines[i]);
                Thread.Sleep(5000);

                //yazılan alıcıyı seç

                IWebElement kultik = driver.FindElement(By.XPath("html/body/div[6]/div/div/div[2]/div[2]")).FindElement(By.TagName("button"));
                kultik.Click();
                Thread.Sleep(5000);

                //yazılan alıcıya tıkla

                IWebElement kultikd = driver.FindElement(By.XPath("html/body/div[6]/div/div/div[1]/div/div[3]/div/button"));
                kultikd.Click();
                Thread.Sleep(5000);

                //mesaj yaz

                IWebElement msjyaz = driver.FindElement(By.XPath("html/body/div[1]/section/div/div[2]/div/div/div[2]/div[2]/div/div[2]/div/div/div[2]/textarea"));
                msjyaz.SendKeys(richTextBox1.Text);
                Thread.Sleep(5000);

                //mesajı gönder

                IWebElement msjyazbtn = driver.FindElement(By.XPath("html/body/div[1]/section/div/div[2]/div/div/div[2]/div[2]/div/div[2]/div/div/div[3]/button"));
                msjyazbtn.Click();
                Thread.Sleep(5000);

                //yeni mesaj yazma butonu 

                IWebElement yenimsj = driver.FindElement(By.XPath("html/body/div[1]/section/div/div[2]/div/div/div[1]/div[1]/div/div[3]/button"));
                yenimsj.Click();
                Thread.Sleep(4000);

            }

            





        }

        private void btnTakipciListele_Click(object sender, EventArgs e)
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

            driver.Navigate().GoToUrl("https://www.instagram.com/" + Form1.kadi);
            Thread.Sleep(4000);


            IWebElement takipclr = driver.FindElement(By.XPath("html/body/div[1]/section/main/div/header/section/ul/li[2]/a/div/span"));
            takipclr.Click();
            Thread.Sleep(4000);

            //Scroll komutları

            string jsCommand = "" +
                   "sayfa = document.querySelector('.isgrP');" +
                   "sayfa.scrollTo(0,sayfa.scrollHeight);" +
                   "var sayfaSonu = sayfa.scrollHeight;" +
                   "return sayfaSonu;";

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            var sayfaSonu = Convert.ToInt32(js.ExecuteScript(jsCommand));

            while (true)
            {
                var son = sayfaSonu;
                Thread.Sleep(1000);
                sayfaSonu = Convert.ToInt32(js.ExecuteScript(jsCommand));
                if (son == sayfaSonu)
                    break;
            }




            //Scroll komutları


            IReadOnlyCollection<IWebElement> followwers = driver.FindElements(By.CssSelector(".notranslate._0imsa"));
            foreach (IWebElement tkplist in followwers)
            {
                richTextBox2.Text += tkplist.Text + "\n";
            }



            // string a =richTextBox2.Lines[0];

        }
    }
}
