# SearchRequestUiTests

## Setup local environment (Selenium standalone service)  

### Download resources needed  

- **Selenium Server Standalone**  
Download the latest version of Selenium server:  
https://www.seleniumhq.org/download/  
All releases can be found here:  
http://selenium-release.storage.googleapis.com/index.html  

- **Internet Explorer driver**  
Download the latest version of Internet Explorer driver from:  
https://www.seleniumhq.org/download/  
All releases can be found here:  
http://selenium-release.storage.googleapis.com/index.html 

- **Chrome driver**  
https://github.com/SeleniumHQ/selenium/wiki/ChromeDriver
Download the latest version of Chrome driver from:  
http://chromedriver.chromium.org/
All releases can be found here:
https://chromedriver.storage.googleapis.com/index.html

### Setup for standalone server and remote webdriver  

- Place server and drivers executables to some directory;
- Start selenium service as standalone local server  
(run in Windows command line as Administrator)  
`java -jar selenium-server-standalone-<version>.jar`

## Run tests
Use VisualStudio itself or `runTests.bat` to run tests. Consider updating PATH variable with path to *vstest.console.exe* in order to run the given file.