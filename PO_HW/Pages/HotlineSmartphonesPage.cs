using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace PO_HW.Pages
{
    public class HotlineSmartphonesPage: BasePage
    {

        public HotlineSmartphonesPage(IWebDriver driver) : base(driver) { }

        [FindsBy(How = How.XPath, Using = "//a[@href='/mobile/mobilnye-telefony-i-smartfony/385521/']")]
        public IWebElement largeBatterySmartphoneFilter;

        [FindsBy(How = How.XPath, Using = "//a[@href='/mobile/mobilnye-telefony-i-smartfony/28009/']")]
        public IWebElement doubleSimSmartphonesFilter;

        [FindsBy(How = How.XPath, Using = "//a[@href='/mobile/mobilnye-telefony-i-smartfony/575308/']")]
        public IWebElement support4GSmartphonesFilter;

        [FindsBy(How = How.XPath, Using = "//a[@href='/mobile/mobilnye-telefony-i-smartfony/385520/']")]
        public IWebElement smarthonesWithAmountOfRAMlargerThan3GBFilter;

        [FindsBy(How = How.XPath, Using = "//a[@href='/mobile/mobilnye-telefony-i-smartfony/38820/']")]
        public IWebElement androidSmartPhoneFilter;

        [FindsBy(How = How.XPath, Using = "//a[@href='/mobile/mobilnye-telefony-i-smartfony/32743/']")]
        public IWebElement durableSmartphoneFilter;

        [FindsBy(How = How.XPath, Using = "//a[@href='/mobile/mobilnye-telefony-i-smartfony/385518/']")]
        public IWebElement smartphoneWithScreenSizeLargerThan5inchesFilter;

        [FindsBy(How = How.XPath, Using = "//a[@href='/mobile/mobilnye-telefony-i-smartfony/385522/']")]
        public IWebElement metalBodyFilter;

        [FindsBy(How = How.XPath, Using = "//a[@href='/mobile/mobilnye-telefony-i-smartfony/575307/']")]
        public IWebElement framelessSmartphonesFilter;

        [FindsBy(How = How.XPath, Using = "//a[@href='/mobile/mobilnye-telefony-i-smartfony/567634/']")]
        public IWebElement pureAndroidOSSmartphoneFilter;

        [FindsBy(How = How.XPath, Using = "//a[@href='/mobile/mobilnye-telefony-i-smartfony/66603/']")]
        public IWebElement phoneForElderlyPeopleFilter;

        [FindsBy(How = How.XPath, Using = "//a[@href='/mobile/mobilnye-telefony-i-smartfony/572578/']")]
        public IWebElement phoneWithAndroidPaySupportFilter;

        [FindsBy(How = How.XPath, Using = "//a[@href='/mobile/mobilnye-telefony-i-smartfony/364210/']")]
        public IWebElement flagmanSmartphonesFilter;

        [FindsBy(How = How.XPath, Using = "//a[@href='/mobile/mobilnye-telefony-i-smartfony/574078/']")]
        public IWebElement memoryExtensionSupportFilter;

        public bool IsFilterDiplayedOnPage(IWebElement filter)
        {
            try
            {
                return filter.Displayed;
            }
            catch (NoSuchElementException e)
            {
                return   false;
            }

        }


    }
}
