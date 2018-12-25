namespace SearchRequestUiTests.PageElements
{
    using System.Collections.Generic;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    /// <summary>
    /// Search Result page
    /// </summary>
    /// <seealso cref="SearchRequestUiTests.PageElements.BasePage" />
    internal class SearchResultsPage : BasePage
    {
        /// <summary> Search Results elements </summary>
        [FindsBy(How = How.XPath, Using = "//div[@class=\"g\"]//div[@class=\"r\"]//a[h3[@class=\"LC20lb\"]]")]
        private IList<IWebElement> searchResultsLinks;

        public SearchResultsPage(IWebDriver driver) : base(driver)
        {
        }

        public IList<IWebElement> GetCurrentSearchResultElements()
        {
            return searchResultsLinks;
        }
    }
}