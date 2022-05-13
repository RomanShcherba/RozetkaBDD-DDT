using System.Threading;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace RozetkaBDD_DDT.Pages
{
    class BucketPage : BasePage
    {
        public BucketPage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this); 
        }

        [FindsBy(How = How.XPath, Using = "//div[@class ='cart-receipt__sum-price']//span[contains(@class,'')]")]
        private IWebElement bucketTotal;

        public int GetBucketSumm()
        {
            return int.Parse(bucketTotal.Text);
        }

    }
}
