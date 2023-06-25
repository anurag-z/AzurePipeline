using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config")]

namespace Azure_Selenium
{
    [Binding]
    public class Hooks:Base
    {
      
        public Hooks(ScenarioContext scenariocontext) : base(scenariocontext)
            {
          
            }

        [BeforeScenario]
        public void BeforeScenario()
        {
            intialize();
            _scenariocontext["driver"] = _driver;
            _driver.Url = "https://www.google.com";
            log.Info("Driver Intialized...");
            _driver.Manage().Window.Maximize();


        }

        [AfterScenario]
        public void AfterScenario()
        {

            _driver.Close();
            if (_driver != null)
            {
                _driver.Quit();
            }
        }
    }
}
