using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsharp_PageObjectModel.Pages
{
    public class CalculatorPage
    {
        IWebDriver driver;
       
        public void initialize(IWebDriver driver)
        {
            this.driver = driver;          
            driver.Navigate().GoToUrl("https://www.calculator.net/");
        }
        public void EnterNumber(string number)
        {
            IWebElement number1;
            char[] ch = number.ToCharArray();

            for (int i = 0; i < number.Length; i++)
            {
                number1 = driver.FindElement(By.XPath("//span[@onclick='r(" + ch[i] + ")']"));
                number1.Click();
            }
        }

        public void ClickonOperator(string op)
        {
            IWebElement op_element = driver.FindElement(By.XPath("//span[@onclick=\"r('" + op + "')\"]"));
            op_element.Click();
        }

        public string calculate(string no1, string op, string no2)
        {
            IWebElement number1;
            char[] ch = no1.ToCharArray();

            for (int i = 0; i < no1.Length; i++)
            {
                number1 = driver.FindElement(By.XPath("//span[@onclick='r(" + ch[i] + ")']"));
                number1.Click();
            }

            IWebElement op_element = driver.FindElement(By.XPath("//span[@onclick=\"r('" +op + "')\"]"));
            op_element.Click();

            ch = no2.ToCharArray();

            for (int i = 0; i < no2.Length; i++)
            {
                number1 = driver.FindElement(By.XPath("//span[@onclick='r(" + ch[i] + ")']"));
                number1.Click();
            }
            IWebElement result = driver.FindElement(By.Id("sciOutPut"));
            string actual_result = result.Text.Trim();
            return actual_result;
        }
    }
}
