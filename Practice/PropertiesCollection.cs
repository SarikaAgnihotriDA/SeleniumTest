using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace Practice
{
    enum Propertytype
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
      
    }
    class PropertiesCollection
    {

       
        public static IWebDriver driver { get; set; }
    }
}
