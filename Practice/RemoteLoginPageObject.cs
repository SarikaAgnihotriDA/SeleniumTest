using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;

namespace Practice
{
    class RemoteLoginPageObject

    {
        public RemoteLoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

    
        [FindsBy(How =How.Name,Using = "username")]
        public IWebElement Username { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement Password { get; set; }

        public void RemoteLoginMethod(String username,String password)
        {
            SeleniumSetMethods.EnterText(Username,username);
            SeleniumSetMethods.EnterText(Password,password);
        }

        
    }
}

