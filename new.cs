using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Program
{
    static void Main(string[] args)
    {

        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");

        IWebElement nameInput = driver.FindElement(By.Id("firstName"));
        nameInput.Clear();
        nameInput.SendKeys("John Doe");

        IWebElement emailInput = driver.FindElement(By.Name("email"));
        emailInput.Clear();
        emailInput.SendKeys("johndoe@example.com");

        IWebElement maleRadioButton = driver.FindElement(By.CssSelector("input[type='radio'][value='male']"));
        maleRadioButton.Click();

        driver.Close();
        driver.Quit();
    }
}
