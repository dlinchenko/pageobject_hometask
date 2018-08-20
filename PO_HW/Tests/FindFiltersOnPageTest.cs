using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using FluentAssertions;
using PO_HW.Pages;

namespace PO_HW.Tests
{
    [TestFixture]
    public class FindFiltersOnPageTest
    {
        private IWebDriver _driver;
        //private WebDriverWait _wait;


        [SetUp]
        public void TestSetup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Url = "https://hotline.ua/mobile/mobilnye-telefony-i-smartfony/";
            new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Close();
        }

        [Test]
        public void TestPopularFiltersAreOnThePage()
        {
            var page = new HotlineSmartphonesPage(_driver);

            page.IsFilterDiplayedOnPage(page.largeBatterySmartphoneFilter).Should().BeTrue("large battery filter should exist on page");
            page.IsFilterDiplayedOnPage(page.doubleSimSmartphonesFilter).Should().BeTrue("filter for double sim smartphones should exist on page");
            page.IsFilterDiplayedOnPage(page.support4GSmartphonesFilter).Should().BeTrue("filter for smartphones with 4G should exist on page");
            page.IsFilterDiplayedOnPage(page.smarthonesWithAmountOfRAMlargerThan3GBFilter).Should().BeTrue("filter for smartphones with RAM amount 3 GB+ should exits on page");
            page.IsFilterDiplayedOnPage(page.androidSmartPhoneFilter).Should().BeTrue("filter to select Adnroid only smartphone should exist on page");
            page.IsFilterDiplayedOnPage(page.durableSmartphoneFilter).Should().BeTrue("filter for durable smartphones should exist on page");
            page.IsFilterDiplayedOnPage(page.smartphoneWithScreenSizeLargerThan5inchesFilter).Should().BeTrue("filter for large screen smartphones should exist on page");
            page.IsFilterDiplayedOnPage(page.metalBodyFilter).Should().BeTrue("filter for smartphones with metal body should exist on page");
            page.IsFilterDiplayedOnPage(page.framelessSmartphonesFilter).Should().BeTrue("filter for smartphones with thin frames should exist on page");
            page.IsFilterDiplayedOnPage(page.pureAndroidOSSmartphoneFilter).Should().BeTrue("filter for smartphones on pure Android should exist on page");
            page.IsFilterDiplayedOnPage(page.phoneForElderlyPeopleFilter).Should().BeTrue("filter for phones for elserly people should exist on page");
            page.IsFilterDiplayedOnPage(page.phoneWithAndroidPaySupportFilter).Should().BeTrue("filter for smartphones with Adroid Pay support should exist on page");
            page.IsFilterDiplayedOnPage(page.flagmanSmartphonesFilter).Should().BeTrue("filter for flagman models should exist on the page");
            page.IsFilterDiplayedOnPage(page.memoryExtensionSupportFilter).Should().BeTrue("filter for smartphones with memory card slot should exist on page");

        }
    }
}
