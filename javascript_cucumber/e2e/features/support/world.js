let webdriver = require('selenium-webdriver');
let chrome = require('selenium-webdriver/chrome');
let chromedriver = require('chromedriver');

chrome.setDefaultService(new chrome.ServiceBuilder(chromedriver.path).build());

function CustomWorld() {

    this.driver = new webdriver.Builder()
        .usingServer('http://chrome:4444/wd/hub')
        .withCapabilities(webdriver.Capabilities.chrome())
        .build();
}

module.exports = function () {
    this.World = CustomWorld;
    this.setDefaultTimeout(60 * 1000);
};
