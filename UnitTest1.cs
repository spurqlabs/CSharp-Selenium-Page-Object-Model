using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SeleniumCsharp_PageObjectModel.Pages;

namespace SeleniumCsharp_PageObjectModel
{
    public class UnitTest1
    {
        IWebDriver driver;
        CalculatorPage calc_page;
        public void initialize_driver()
        {
            driver = new ChromeDriver(@"../../../Resources");
            calc_page = new CalculatorPage();
        }

        public void close_driver()
        {
            driver.Close();
        }

        [Fact]
        public void Add()
        {
            initialize_driver();
            calc_page.initialize(driver);
            string actualresult = calc_page.calculate("14", "+", "5");
            Assert.Equal("19", actualresult);
            close_driver();
        }

        [Fact]
        public void Subtract()
        {
            initialize_driver();
            calc_page.initialize(driver);
            string actualresult = calc_page.calculate("24", "-", "5");
            Assert.Equal("19", actualresult);
            close_driver();
        }
    }
}