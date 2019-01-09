using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;


namespace Practice
{
    class SeleniumGetMethods
    {
       
        public static String GetText(Propertytype elementtype,String element)
        {
            String Data;
            if (elementtype==Propertytype.Id)
            {
                 Data= PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("value");
                return Data;
            }
            if (elementtype == Propertytype.Name)
            {
                Data = PropertiesCollection.driver.FindElement(By.Name(element)).GetAttribute("value");
                return Data;
            }
            else
                Data = String.Empty;
            return Data;
        }


    }
}
