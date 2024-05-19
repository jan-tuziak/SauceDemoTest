using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SauceDemoTest;

[Parallelizable(ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class Tests
{
    protected IWebDriver driver;
    public const string Url = "https://www.saucedemo.com/";

    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl(Url);
    }

    [TearDown]
    public void TearDown()
    {
        driver.Quit();
        driver.Dispose();
    }

    [Test]
    public void Test1()
    {
        Thread.Sleep(10000);
    }

    [Test]
    public void Test2()
    {
        Thread.Sleep(10000);
    }
}