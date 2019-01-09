using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;


namespace Practice
{
   public static  class SeleniumGetMethods
    {
        //Get value from a textbox
        public static String GetText(this IWebElement element)
        {
            String Data;

            Data = element.GetAttribute("value");
            return Data;

        }
        //Get value from Checkbox,Radiobutton etc

        public static String GetDDLValue(this IWebElement element)
        {
            String Data1;

            Data1 = new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
            return Data1;


        }

    }
}