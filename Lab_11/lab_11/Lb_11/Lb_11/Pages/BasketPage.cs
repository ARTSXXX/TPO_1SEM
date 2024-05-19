using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using static Lb_11.Log.Log;

namespace Lb_11.Pages
{
    internal class BasketPage :PageBase.PageBase
    {
        public BasketPage(IWebDriver driver) : base(driver)
        {

        }

        public bool IsProductInBasket()
        {
            try
            {
               
                return true;
            }
            catch (NoSuchElementException)
            {
                Info("Product is not in basket.");
                return false;
            }
        }
    }
}
