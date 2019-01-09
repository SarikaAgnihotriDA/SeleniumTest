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
            PropertiesCollection.driver.Navigate().GoToUrl("file:///C:/Users/Lenovo/Desktop/Login%20design/index.html");
            Console.WriteLine("Login Page Opened");
            

 
        }
        [Test]
        public void LoginPage()
        {
            //initialize the login page
            LoginPageObject pageLogin = new LoginPageObject();

           EAPageObject EAPage= pageLogin.Login("Sarika", "Sarika123");

            EAPage.FillUserForm("Sarika", "Sharma", "sarika601@ymail.com", "Sarika601@ymail.com", "Sarika123");
            
            //initialize page
            EAPageObject page = new EAPageObject();
            
        


            //SeleniumSetMethods.EnterText("firstname", Propertytype.Name, "Divya");
            //SeleniumSetMethods.EnterText("lastname", Propertytype.Name, "Agnihotri");
            //SeleniumSetMethods.EnterText("reg_email__", Propertytype.Name, "sarikasharma146@gmail.com");
            //SeleniumSetMethods.EnterText("reg_passwd__", Propertytype.Name, "2256810");

            //SeleniumSetMethods.SelectDDL("birthday_day", "28", Propertytype.Name);
            //SeleniumSetMethods.SelectDDL("birthday_month", "2", Propertytype.Name);
            //SeleniumSetMethods.SelectDDL("birthday_year", "1995", Propertytype.Name);
            //SeleniumSetMethods.Click("sex", Propertytype.Name);
            ////SeleniumSetMethods.click(driver, "websubmit", "Name"); 

            ////Console.WriteLine("Details filled Successfully");


            //Console.WriteLine("The email id is: " + SeleniumGetMethods.GetText(Propertytype.Name, "reg_email__"));
            //Console.WriteLine("the Date of Birth is :" + SeleniumGetMethods.GetDDLValue(Propertytype.Name, "birthday_day") + "/"
            //    + SeleniumGetMethods.GetDDLValue(Propertytype.Name, "birthday_month") + "/"
            //    + SeleniumGetMethods.GetDDLValue(Propertytype.Name, "birthday_year"));



            //Console.WriteLine("Details filled Successfully");
        }

        [TearDown]
        public void cleanup()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Browser closed");

        }
    }

}