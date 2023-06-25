using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;

namespace Azure_Selenium
{
    public class Driver
    {
        private static Driver _driver;
        private IWebDriver _webdriver;
        private Driver()
        {
            Intiliaziedriver();
        }

        public static Driver driver 
        {
            get {
                if (_driver == null)
                { 
                    _driver = new Driver();
                
                }
                return _driver;
              }
        }


        public void Intiliaziedriver()
        {

            ChromeOptions options= new ChromeOptions();
            options.AddArgument("--maximize");
            options.AddArgument("--ignonicto");
            _webdriver = new ChromeDriver(options);

        }

        public IWebDriver webdriver()
        {
            return _webdriver;
        }
    }
}
