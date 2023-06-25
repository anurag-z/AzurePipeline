using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Azure_Selenium
{
    public class Base
    {
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioContext _scenariocontext;
      public  IWebDriver _driver;
        public Base(ScenarioContext scenariocontext)
        { 
        _scenariocontext = scenariocontext;

        }
        public void intialize()
        { 
            Driver d= Driver.driver;
            _driver = d.webdriver();
        }
       
    }
}
