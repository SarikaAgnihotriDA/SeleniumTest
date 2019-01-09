using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Practice
{
    class EAPageObject
    {
        public EAPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        //facebook page elements

        [FindsBy(How =How.Name,Using ="firstname")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How =How.Name,Using = "lastname")]
        public IWebElement LastName { get; set; }

        [FindsBy(How =How.Name,Using = "reg_email__")]
        public IWebElement Registered_Email  { get; set; }

        [FindsBy(How =How.Name,Using = "reg_passwd__")]
        public IWebElement Registered_Password { get; set; }

        [FindsBy(How =How.Name,Using = "websubmit")]
        public IWebElement Save_Button { get; set; }

        [FindsBy(How =How.Name,Using = "reg_email_confirmation__")]
        public IWebElement Confirmation_Email { get; set; }

       public void FillUserForm(String firstname,String lastname,String regemail,String confemail,String regpwd)
        {
            //SeleniumSetMethods.EnterText(FirstName, firstname);
            //SeleniumSetMethods.EnterText(LastName, lastname);
            //SeleniumSetMethods.EnterText(Registered_Email, regemail);
            //SeleniumSetMethods.EnterText(Confirmation_Email, confemail);
            //SeleniumSetMethods.EnterText(Registered_Password, regpwd);
            //SeleniumSetMethods.Click(Save_Button);





            FirstName.EnterText(firstname);
            LastName.EnterText(lastname);
            Registered_Email.EnterText(regemail);
            Confirmation_Email.EnterText(confemail);
            Registered_Password.EnterText(regpwd);
            Save_Button.Clickk();
            Console.WriteLine("Details filled successfully");
            Console.WriteLine("Changes Done");
        }


    }
}
