using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        //create a reference for browser
       
        static void Main(string[] args)
        {

        }
        [SetUp]
        public void initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            //navigate to a url
            PropertiesCollection.driver.Navigate().GoToUrl("http://www.facebook.com");
            Console.WriteLine("Browser opened");


        }
        [Test]
        public void Test1()
        {
            //SeleniumSetMethods.EnterText("email", Propertytype.Name, "sarika601@ymail.com");
            //SeleniumSetMethods.EnterText("pass", Propertytype.Name, "2256810");

            SeleniumSetMethods.EnterText("firstname", Propertytype.Name,"Sarika");
            SeleniumSetMethods.EnterText("lastname", Propertytype.Name, "Sharma");
            SeleniumSetMethods.EnterText("reg_email__", Propertytype.Name, "sarika601@ymail.com");
            SeleniumSetMethods.EnterText("reg_passwd__", Propertytype.Name, "2256810");
          

            Console.WriteLine("The email id is: " + SeleniumGetMethods.GetText(Propertytype.Name, "reg_email__"));
           

            Console.WriteLine("Details filled");
        }

        [TearDown]
        public void cleanup()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Browser closed");

        }
    }

}