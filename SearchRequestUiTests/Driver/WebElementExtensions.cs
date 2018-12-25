namespace SearchRequestUiTests.Driver
{
    using System;
    using System.Threading;
    using OpenQA.Selenium;

    static class WebElementExtensions
    {
        public static void WaitAndClick(this IWebElement element)
        {
            RetryAction(element.Click);
        }

        private static void RetryAction(Action action, int attemptsCount = 5, int millisecondsTimeOut = 2000)
        {
            var exception = new Exception();
            for (var i = 0; i < attemptsCount; i++)
            {
                try
                {
                    action.Invoke();
                    return;
                }
                catch (Exception targetException)
                {
                    exception = targetException;
                    Thread.Sleep(millisecondsTimeOut);
                }
            }

            throw exception;
        }
    }
}