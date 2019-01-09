using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace Practice
{
    class SeleniumSetMethods
    {

        //Enter test method
        public static void EnterText(String element, Propertytype elementType, String value)
        {
            if (elementType == Propertytype.Id)
            {
                PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            }
            if (elementType == Propertytype.Name)
            {
                PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
            }

        }

        public static void Click(String element, Propertytype elementType)
        {
            if (elementType == Propertytype.Id)
            {
                PropertiesCollection.driver.FindElement(By.Id(element)).Click();
            }
            if (elementType == Propertytype.Name)
            {
                PropertiesCollection.driver.FindElement(By.Name(element)).Click();
            }
        }

        public static void SelectDropDown(String element, Propertytype elementtype, String value)
        {
            if (elementtype == Propertytype.Id)
            {
                new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);

            }
            if (elementtype == Propertytype.Name)
            {
                new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
            }
        }
    }

}
