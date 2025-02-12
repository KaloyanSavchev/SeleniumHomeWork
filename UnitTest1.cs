using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumTest
{

    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            var driverOptions = new ChromeOptions();
            driverOptions.AddArgument("--start-maximized");
            driver = new ChromeDriver();
            driver.Url = "https://www.ozone.bg/";

            
        }

        [Test]
        public void TitleLoading_When_SiteLoad()
        {
            Thread.Sleep(2000);
            string expectedTitle = "Mагазин за игри, книги, геймърски аксесоари и играчки | Ozone.bg";
            string actualTitle = driver.Title; 
            Console.WriteLine(expectedTitle, actualTitle);
          
            Assert.AreEqual(expectedTitle, actualTitle, "The title is not as expected!");
        }

        [TearDown]
        public void TearDown()
        {
           driver.Quit();
        }
    }
}
