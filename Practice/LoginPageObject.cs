using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace Practice
{
    class LoginPageObject
    {


        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }


        //Loginpage Elements
        [FindsBy(How = How.Name, Using = "txtusername")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Name, Using = "txtpwd")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Name, Using = "btnsubmit")]
        public IWebElement Loginbutton { get; set; }


        public EAPageObject Login(String username, String password)
        {
            //SeleniumSetMethods.EnterText(UserName, username);
            //SeleniumSetMethods.EnterText(Password, password);
            //SeleniumSetMethods.Click(Loginbutton);
            //PropertiesCollection.driver.Navigate().GoToUrl("http://www.facebook.com");
           
          

            UserName.EnterText(username);
            Password.EnterText(password);
            Loginbutton.Clickk();
            PropertiesCollection.driver.Navigate().GoToUrl("http://facebook.com");
            return new EAPageObject();

        }
    }
    }
