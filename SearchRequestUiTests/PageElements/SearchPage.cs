namespace SearchRequestUiTests.PageElements
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;
    using SearchRequestUiTests.Driver;

    /// <summary>
    /// Google Search page
    /// </summary>
    /// <seealso cref="SearchRequestUiTests.PageElements.BasePage" />
    internal class SearchPage : BasePage
    {
        /// <summary>
        /// The search input field
        /// </summary>
        [FindsBy(How = How.Name, Using = "q")]
        private IWebElement searchInputField;

        /// <summary>
        /// The search in google button
        /// </summary>
        [FindsBy(How = How.Name, Using = "btnK")]
        private IWebElement searchInGoogleButton;

        public SearchPage(IWebDriver driver) : base(driver)
        {
        }

        public SearchPage ClickSearchButton()
        {
            searchInGoogleButton.WaitAndClick();
            return this;
        }

        public SearchPage TypeIntoSearchField(string searchRequestString)
        {
            searchInputField.SendKeys(searchRequestString);
            return this;
        }

        public SearchPage NavigateTo()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            return this;
        }
    }
}