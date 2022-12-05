using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using Payback_Po.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payback_Po.Pages
{

    public class loginPage : utility
    {
        private IWebDriver driver;
       


        public loginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void loginButton()
        {
            IWebElement login = driver.FindElement(By.LinkText("Login"));
            login.Click();
        }
        public void LoginUser()
        {
            IWebElement usernameValue = driver.FindElement(By.Name("card_number"));
            usernameValue.SendKeys("9527966393");


        }


        public void LoginPassword()
        {
            IWebElement passwordText = driver.FindElement(By.Name("pin_number"));
            passwordText.SendKeys("1997");

        }

        /*public void CaptchaClicking()
        {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            var browser_button = driver.FindElement(By.XPath("//*[@id=\"rc-anchor-container\"]/div[3]/div[1]/div"));
         //   browser_button.Click();
            ////*[@id="rc-anchor-container"]
            IWebElement Captcha = wait.Until(condition: SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"rc-anchor-container\"]")));
            // driver.FindElement(By.XPath("//*[@id=\"rc-anchor-container\"]")).Click();
            Captcha.Click();
            Console.WriteLine("Captcha Clicked");

        }*/
        public HomePage loginButton1()
        {
            IWebElement loginButton = driver.FindElement(By.XPath("//button[@class='btn pb-login-submit red-button']"));
            loginButton.Click();
            return new HomePage(driver);
        }

    }
}
