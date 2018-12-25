namespace SearchRequestUiTests.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium;

    static class Assertions
    {
        public static void CheckLinkElementContainsExpectedText(IWebElement linkElement, string expectedLinkText)
        {
            StringAssert.Contains(linkElement.Text, expectedLinkText, "Link contains incorrect text");
        }
    }
}