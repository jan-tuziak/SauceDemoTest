using OpenQA.Selenium.Chrome;

namespace SauceDemoTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var driver = new ChromeDriver();
            
        driver.Navigate().GoToUrl("https://selenium.dev");
            
        driver.Quit();
    }
}