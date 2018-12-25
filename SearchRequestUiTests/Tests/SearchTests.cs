namespace SearchRequestUiTests.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium;
    using SearchRequestUiTests.Data;
    using SearchRequestUiTests.Driver;


    [TestClass]
    public class SearchTests
    {
        private SearchRequestManager searchRequestManager;

        private IWebDriver driver;

        [TestInitialize]
        public void TestInit()
        {
            this.driver = DriverContext.CreateDriver();
            this.searchRequestManager = new SearchRequestManager(driver);
        }

        [DataRow("yandex.ru")]
        [DataRow("stackoverflow")]
        [DataTestMethod]
        public void GoogleSearchParticularResourceMustReturnExpectedResourceLinkAtTheTop(string expectedLinkText)
        {
            var searchRequest = new SearchRequest
            {
                SearchString = expectedLinkText
            };

            searchRequestManager.SubmitSearchRequest(searchRequest);

            var firstResultLink = searchRequestManager.FindFirstResultElementLink();
            Assertions.CheckLinkElementContainsExpectedText(firstResultLink, expectedLinkText);
        }

        [TestCleanup]
        public void TestTearDown()
        {
            driver.Quit();
        }
    }
}