using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // definējam selenium draiveri
        IWebDriver driver;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path;
            // ==================================== ceļš uz selenium
            path = @"C:\Users\Kalvis\Desktop\Studijas\kursi\7.semestris\Programmaturas izstrades tehnologijas\BrowserDrivers";
            var options = new ChromeOptions();
            options.AddExcludedArgument("enable-logging");
            driver = new ChromeDriver(path, options);
            driver.Url = "https://www.ebay.com/";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchText, url;
            searchText = textBox1.Text;
            driver.FindElement(By.Id("gh-ac")).SendKeys(searchText);
            driver.FindElement(By.Id("gh-btn")).Click();
            url = driver.Url;
            textBox2.Text = url;
            richTextBox1.AppendText(url + "\n"); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            driver.Navigate().Back();
            textBox1.Clear();
            textBox2.Clear();
            //richTextBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //izslēdz pārlūku
            driver.Quit();
        }
    }
}
