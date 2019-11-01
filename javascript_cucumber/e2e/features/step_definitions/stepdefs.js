let assert = require('assert');
let loginPage = require('../../page-objects/LoginPage');

module.exports = function () {

    this.Given(/^I am on "([^"]*)"$/, function (arg1) {
        return this.driver.get(arg1);
    });

    this.Then(/^I should see "([^"]*)" in title$/, function (text) {
        return this.driver.getTitle().then(function (title) {
            assert.equal(title, text)
        })
    });

    this.When(/^I click on "([^"]*)"$/, function (element) {
        return this.driver.findElement(loginPage.elements[element]).click()
    });

    this.When(/^I fill in "([^"]*)" with "([^"]*)"$/, function (field, value) {
        return this.driver.findElement(loginPage.elements[field]).sendKeys(value);
    });
};

