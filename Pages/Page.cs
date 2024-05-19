using OpenQA.Selenium;

namespace SauceDemoTest;

public abstract class Page
{
    protected IWebDriver driver;
    public Page(IWebDriver driver)
    {
        this.driver = driver;
    }


}
