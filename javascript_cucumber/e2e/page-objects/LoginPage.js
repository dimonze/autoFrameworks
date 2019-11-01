const {By} = require("selenium-webdriver");

module.exports = {
    elements: {
        UserName: By.id("identity"),
        Password: By.id("password"),
        SignIn: By.name("submit"),
        Title: By.xpath("//title"),
    }
};
