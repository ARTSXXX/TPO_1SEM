using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using static Lb_11.Log.Log;

namespace Lb_11.Pages
{
    internal class MainPage : PageBase.PageBase
    {
        private readonly string _baseUrl = "https://ozon.by/";

        public MainPage(IWebDriver driver) : base(driver)
        {
        }

        public void Open()
        {
            Driver.Navigate().GoToUrl(_baseUrl);
            Info("Main page opened.");
        }

        public void Search(string searchText)
        {
            Info("Searching for " + searchText);
            IWebElement searchInput = Driver.FindElement(By.XPath("//*[@id=\"stickyHeader\"]/div[2]/div/div/form/div[1]/div[2]/input[1]"));
            searchInput.Click();
            searchInput.SendKeys(searchText);
            searchInput.SendKeys(Keys.Enter);
            Info("Search completed.");
        }

        public void ClickCatalog()
        {
            IWebElement catalogButton = Driver.FindElement(By.XPath("//*[@id=\"layoutPage\"]/div[1]/header/div[2]/div/div/ul/li[2]/a"));
            catalogButton.Click();
            Info("Catalog clicked.");
        }

        public void ClickITJob()
        {
            IWebElement catalogButton = Driver.FindElement(By.XPath("//*[@id=\"layoutPage\"]/div[1]/div[3]/div/footer/div[1]/div[1]/div/a[1]"));
            catalogButton.Click();
            Info("IT job clicked.");

            // Получаем идентификаторы всех открытых окон
            List<string> windowHandles = new List<string>(Driver.WindowHandles);

            // Переключаемся на последнее открытое окно (новую страницу)
            Driver.SwitchTo().Window(windowHandles[windowHandles.Count - 1]);

            Info("Clicked on the section and switched to the new page.");
        }
    }
}
