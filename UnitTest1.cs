using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Security.Cryptography.X509Certificates;
namespace TestProject1
{
    public class UnitTest1
    {

        IWebDriver driver;

        public UnitTest1()
        {
            driver = new ChromeDriver(@"C:\Users\Priti Gaikwad\Downloads\chromedriver-win64\chromedriver-win64");

            driver.Navigate().GoToUrl("http://www.facebook.com");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

        }

        [Fact]
        public void Test1()
        {
            IWebElement element1 = driver.FindElement(By.Id("email"));
            element1.SendKeys("abc11@gmail.com");
            Thread.Sleep(1000);
            IWebElement ele1 = driver.FindElement(By.Name("pass"));
            //enter the password value  
            ele1.SendKeys("Priti123");
            Thread.Sleep(1000);
            IWebElement ele2 = driver.FindElement(By.Name("login"));
            ele2.Click();
            Thread.Sleep(1000);
            driver.Close();
        }

    }

}
