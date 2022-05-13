using NUnit.Framework;
using RozetkaBDD_DDT.DataSource;
using RozetkaBDD_DDT.Pages;
using RozetkaBDD_DDT.Utils;


namespace RozetkaBDD_DDT.Tests
{
    [TestFixture]
    public class BucketVerifyTest : BaseTest
    {
        
        [TestCaseSource(typeof(DataProvider), nameof(DataProvider.TestData))]
        public void ExecuteTest(Filter filter)
        {
            HomePage homePage = new HomePage(driver);
            homePage.SearchByKeyword(filter.nameProducts);
            homePage.ClickSearchButton();
            SearchResultsPage searchResultsPage = new SearchResultsPage(driver);
            searchResultsPage.FilterByBrand(filter.brand);
            searchResultsPage.ChangeSortingHigh(filter.sort);
            searchResultsPage.BuyFirstProduct();
            searchResultsPage.ClickCartButton();
            BucketPage bucketPage = new BucketPage(driver);
            int total = bucketPage.GetBucketSumm();
            Assert.That(total, Is.LessThan(filter.price));

        }
    }
}
