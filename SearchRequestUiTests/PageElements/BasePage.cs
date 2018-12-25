namespace SearchRequestUiTests.PageElements
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    /// <summary>
    /// 
    /// </summary>
    internal abstract class BasePage
    {
        /// <summary>
        /// The driver
        /// </summary>
        protected IWebDriver driver;

        /// <summary>
        /// Initializes a new instance of the <see cref="BasePage"/> class.
        /// </summary>
        /// <param name="driver">The driver.</param>
        protected BasePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
    }
}