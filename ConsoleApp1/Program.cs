using java.sql;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;

namespace ConsoleApp1
{
    class Program
    {         
            IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
            Console.WriteLine("end to end scenario for cdouk vega ");
           
        }
        [SetUp]
        public void execute() { 

            Console.WriteLine("load browser");
        }
        [Test]
        public void method1()
        {
            driver.Navigate().GoToUrl("https://cdouk-vega.rockycloud.co.uk/");

            Console.WriteLine("open icp bol");

           driver.Manage().Window.Maximize();

            System.Threading.Thread.Sleep(7000);

            //click on clothing 
             Utitlitymethod.Click_method(driver, "/html/body/div[2]/div[2]/div[2]/nav/ul/li[4]", "XPath");
              System.Threading.Thread.Sleep(5000);

            //expand clothing for her section
            Utitlitymethod.Click_method(driver, "/html/body/div[6]/div[2]/div[1]/ul/li[1]/span[1]", "XPath");
           // System.Threading.Thread.Sleep(3000);

            //select option skirts 
            Utitlitymethod.Click_method(driver, "/html/body/div[6]/div[2]/div[1]/ul/li[1]/ul/li[4]", "XPath");
            System.Threading.Thread.Sleep(5000);

            //scroll page
            //   var js = (IJavaScriptExecutor)driver;
            // js.ExecuteScript("window.scrollTo(10, document.body.scrollHeight)");//*[@id="optId-"]/div/a[4]


            //clcik on skater skirts 
            Utitlitymethod.Click_method(driver, "/html/body/div[6]/div[1]/div[4]/div[1]/a/div[2]/div", "XPath");
            System.Threading.Thread.Sleep(5000);

            //click on start design button
            Utitlitymethod.Click_method(driver, "/html/body/div[5]/div/div/div[3]/div[4]/a", "XPath");
            System.Threading.Thread.Sleep(7000);

            //Select size "M" ,skirt length "Short" , Binding color "pink binding" , Add stin label "No label" , Top stich thread color "black thread"

            Utitlitymethod.Click_method(driver, "//*[@id='optId-']/div/a[4]/span/img", "XPath");
            System.Threading.Thread.Sleep(5000);

             Utitlitymethod.Click_method(driver, "/html/body/div[5]/div/div/form/div[2]/div[2]/div[2]/div[3]/div/fieldset/div[2]/div/a[2]/span/img", "XPath");
                 System.Threading.Thread.Sleep(2000);

                Utitlitymethod.Click_method(driver, "/html/body/div[5]/div/div/form/div[2]/div[2]/div[2]/div[3]/div/fieldset/div[3]/div/a[4]/span/img", "XPath");
                System.Threading.Thread.Sleep(2000);

                Utitlitymethod.Click_method(driver, "/html/body/div[5]/div/div/form/div[2]/div[2]/div[2]/div[3]/div/fieldset/div[4]/div/a[1]/span/img", "XPath");
                System.Threading.Thread.Sleep(2000);

                Utitlitymethod.Click_method(driver, "/html/body/div[5]/div/div/form/div[2]/div[2]/div[2]/div[3]/div/fieldset/div[5]/div/a[2]/span/img", "XPath");
                System.Threading.Thread.Sleep(3000);

                //click on design button
                Utitlitymethod.Click_method(driver, "/html/body/div[5]/div/div/form/div[2]/div[2]/div[2]/div[4]/button", "XPath");
                System.Threading.Thread.Sleep(2000);

                //click on image library tab
                Utitlitymethod.Click_method(driver, "/html/body/div[5]/div/div/div[5]/div/div/ul/li[8]/a/p", "XPath");
                System.Threading.Thread.Sleep(5000);

                //select image 
                Utitlitymethod.Click_method(driver, "/html/body/div[5]/div/div/div[5]/div/div/div[7]/div/div[2]/div/ul/li[15]/img","XPath");
                System.Threading.Thread.Sleep(2000);

                //update backside design 
                Utitlitymethod.Click_method(driver, "/html/body/div[5]/div/div/form/div[1]/div[6]/div[2]/div/a[2]/span[1]/img", "XPath");
                System.Threading.Thread.Sleep(5000);

                //click on image library tab
                Utitlitymethod.Click_method(driver, "image-lib-link", "Id");
                System.Threading.Thread.Sleep(5000);

                //select image 
                Utitlitymethod.Click_method(driver, "/html/body/div[5]/div/div/div[5]/div/div/div[7]/div/div[2]/div/ul/li[15]/img", "XPath");
                System.Threading.Thread.Sleep(2000);

                //update qty to 15
                Utitlitymethod.Click_method(driver, "span-quantity", "Id");
                System.Threading.Thread.Sleep(2000);
                Utitlitymethod.Sendkeys_method(driver, "txtQuantity", "5", "Id");
                System.Threading.Thread.Sleep(2000);
                Utitlitymethod.Click_method(driver, "btn-set-quantity", "Id");
    
               //click on preview and buy button
               Utitlitymethod.Click_method(driver, "btnFinalPreview", "Id");

               //click on proceed to cart button
               Utitlitymethod.Click_method(driver, "/html/body/div[5]/div/div/div[6]/div[15]/div[4]/button[2]", "XPath");
               System.Threading.Thread.Sleep(7000);

              //click on go to secure checkout button
              Utitlitymethod.Click_method(driver, "btnCheckout", "Id");
              System.Threading.Thread.Sleep(5000);

              driver.SwitchTo().Frame("klarna-checkout-iframe");

             //send value to country dropdown 
              Utitlitymethod.Click_method(driver, "//*[@id='fieldset']/div[1]/div/div/label/div/div[2]","XPath");

              //OpenQA.Selenium.Interactions.Actions action = new Actions(driver);
              //action.SendKeys("abc@gmail.com");
            
        }
        [TearDown]
        public void close()
        {
            driver.Close();

            Console.WriteLine("close browser");
        }
    }
}
