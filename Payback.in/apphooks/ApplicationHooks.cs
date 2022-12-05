using Payback_Po.Pages;
using Payback_Po.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Payback_Po.apphooks
{
    public class ApplicationHooks : utility
    {

        public loginPage lp;
        public offersPage op;
        public HomePage hp;
        public OurPartner ourP;
        public Recharge rp;
        
       
        
        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("I'm in Before scenario");
            LaunchBrowser("CHROME");
            browserMaximize();
            LaunchApp(url);

            Thread.Sleep(5000);

            lp = new loginPage(driver);
            hp = new HomePage(driver);
            op = new offersPage(driver);
            ourP = new OurPartner(driver);
            rp = new Recharge(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("----------  I'm in After Scenario  -----------");
            Thread.Sleep(5000);
            CloseBrowser();
            Console.WriteLine("Closing the Browser");
        }
    }
}
