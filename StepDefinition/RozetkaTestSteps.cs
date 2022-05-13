using NUnit.Framework;
using RozetkaBDD_DDT.Pages;
using RozetkaBDD_DDT.Tests;
using TechTalk.SpecFlow;

namespace RozetkaBDD_DDT.StepDefinition
{

    [Binding]
    public class RozetkaTestSteps : BaseTest
    {
      [Given(@"I entered '(.*)' in search field")]
        public void IEnteredSearchTextInSearchField(string searchText)
        {
          var homePage = new HomePage(driver);
          homePage
                .SearchByKeyword(searchText);
        }

        [When(@"I click on search button")]
        public void IClickOnSeachButton()
        {
            var homePage = new HomePage(driver);
            homePage
                .ClickSearchButton();
        }
        [When (@"I choose '(.*)'")]
        public void IChooseBrand(string brand)
        {
            var searchResultsPage = new SearchResultsPage(driver);
            searchResultsPage
                .FilterByBrand(brand);
        }
        [When (@"I sort products from expensive to cheaper")]
        public void ISortProductsFromExpensiveToCheaper()
        {
            var searchResultsPage = new SearchResultsPage(driver);
            searchResultsPage
                .ChangeSortingHigh(2);
        }
        [When (@"I click on buy button")]
        public void IClickOnBuyButton()
        {
            var searchResultsPage = new SearchResultsPage(driver);
            searchResultsPage
                .BuyFirstProduct();
        }
        [When (@"I click on cart button")]
        public void IClickOnCartButton()
        {
            var searchResultsPage = new SearchResultsPage(driver);
            searchResultsPage
                .ClickCartButton();
        }
        [Then(@"I check summ in bucket '(.*)'")]
        public void ICheckSummInBucket(int topAmount)
        {
            var bucketPage = new BucketPage(driver);
            int total = bucketPage.GetBucketSumm();
            Assert.That(total, Is.LessThan(topAmount));
        }
    }
}
