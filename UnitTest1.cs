using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Interactions;

namespace Whatsapp_Automation
{
    [TestClass]
    public class UnitTest1
    {
        public static IWebDriver driver = new ChromeDriver();

        [TestMethod]
        public void TestMethod1()
        {
            driver.Url = "https://web.whatsapp.com/";

            driver.Manage().Window.Maximize();

            Thread.Sleep(20000);

            for (int j = 0; j < 2; j++)
            {
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//*[@id=\"pane-side\"]/div[2]/div/div/div[1]/div/div/div/div[2]/div[1]/div[1]/div/span")).Click();

                Thread.Sleep(1000);

                driver.FindElement(By.XPath("//*[@id=\"main\"]/header/div[3]/div/div[3]/div/div/span")).Click();

                Thread.Sleep(1000);

                driver.FindElement(By.XPath("//*[@id=\"app\"]/div/span[5]/div/ul/div/div/li[2]/div")).Click();

                Thread.Sleep(1000);

                try
                {
                    driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div[4]/div/div[3]/div/div[2]/div[2]/div[4]/div/div/span/div/div")).Click();
                }
                catch (Exception ex)
                {
                    driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div[4]/div/div[3]/div/div[2]/div[2]/div[3]/div/div/span/div/div")).Click();
                }
                                         
                Thread.Sleep(1000);

                driver.FindElement(By.XPath("//*[@id=\"main\"]/span[2]/div/button[4]/span")).Click();


                Actions actions = new Actions(driver);

                for (int i = 0; i < 1000; i++)
                {
                    // Send the Arrow Down key
                    actions.SendKeys(Keys.ArrowDown).Perform();
                }

                Thread.Sleep(2000); // Just to observe the effect


                driver.FindElement(By.XPath("/html/body/div[1]/div/div/span[2]/div/div/div/div/div/div/div/div[2]/div/div/div/div[15]/div/div[2]/div")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("/html/body/div[1]/div/div/span[2]/div/div/div/div/div/div/div/div[2]/div/div/div/div[14]/div/div[2]/div")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("/html/body/div[1]/div/div/span[2]/div/div/div/div/div/div/div/div[2]/div/div/div/div[12]/div/div[2]/div")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("/html/body/div[1]/div/div/span[2]/div/div/div/div/div/div/div/div[2]/div/div/div/div[12]/div/div[2]/div")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("/html/body/div[1]/div/div/span[2]/div/div/div/div/div/div/div/div[2]/div/div/div/div[9]/div/div[2]/div")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("/html/body/div[1]/div/div/span[2]/div/div/div/div/div/div/div/span/div/div/div/span")).Click();
            }

            driver.Close();
            driver.Dispose();
            driver.Quit();

        }
    }
}