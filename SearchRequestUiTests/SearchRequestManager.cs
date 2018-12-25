namespace SearchRequestUiTests
{
    using OpenQA.Selenium;
    using System.Linq;
    using SearchRequestUiTests.Data;
    using SearchRequestUiTests.PageElements;

    class SearchRequestManager
    {
        private readonly SearchPage searchPage;
        private readonly SearchResultsPage searchResultPage;

        public SearchRequestManager(IWebDriver driver)
        {
            searchPage = new SearchPage(driver).NavigateTo();
            searchResultPage = new SearchResultsPage(driver);
        }

        public void SubmitSearchRequest(SearchRequest searchRequest)
        {
            searchPage.TypeIntoSearchField($"{searchRequest.TargetSite} {searchRequest.SearchString}")
                .ClickSearchButton();
        }

        public IWebElement FindFirstResultElementLink()
        {
            return searchResultPage.GetCurrentSearchResultElements().FirstOrDefault();
        }
    }
}