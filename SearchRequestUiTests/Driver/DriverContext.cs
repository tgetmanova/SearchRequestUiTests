namespace SearchRequestUiTests.Driver
{
    using System;
    using System.Configuration;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Remote;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.IE;

    class DriverContext
    {
        public static RemoteWebDriver CreateDriver()
        {
            var uri = new Uri(ConfigurationManager.AppSettings["seleniumAddress"]);
            var driver = new RemoteWebDriver(uri,
                GetCapabilitiesForDriverType(ConfigurationManager.AppSettings["driverType"]));

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.Manage().Window.Maximize();
            return driver;
        }

        private static ICapabilities GetCapabilitiesForDriverType(string driverType)
        {
            switch (driverType)
            {
                case "ie":
                    return IeCapabilities();
                case "chrome":
                    return new ChromeOptions().ToCapabilities();
                default:
                    throw new ArgumentException($"Unknown driver type: {driverType}");
            }
        }

        private static ICapabilities IeCapabilities()
        {
            var options = new InternetExplorerOptions
            {
                EnsureCleanSession = true,
                BrowserVersion = "11",
                PlatformName = "WINDOWS",
                EnableNativeEvents = false,
                IntroduceInstabilityByIgnoringProtectedModeSettings = true,
                IgnoreZoomLevel = true,
                UnhandledPromptBehavior = UnhandledPromptBehavior.Accept
            };
            return options.ToCapabilities();
        }
    }
}