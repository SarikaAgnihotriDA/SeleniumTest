using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;

namespace Practice
{
   public static class SeleniumSetMethods
    {

        //Enter test method
        public static void EnterText(this IWebElement element, String value)
        {
            
            element.SendKeys(value);

        }

        public static void Clickk(this IWebElement element)
        {
            element.Click();
        }

        public static void SelectDDL(this IWebElement element, String value)
        {

            new SelectElement(element).SelectByValue(value);


        }
    }

}
