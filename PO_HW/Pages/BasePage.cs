using OpenQA.Selenium;
using SeleniumExtras.PageObjects;



namespace PO_HW.Pages
{
    public class BasePage
    {
        protected IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }
    }
}
