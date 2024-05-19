using OpenQA.Selenium;

namespace SauceDemoTest;

public class LoginPage(IWebDriver driver) : Page(driver)
{
    public By Username = By.Id("user-name");
    public By Password = By.Id("password");
    public By LoginButton = By.Id("login-button");
}
