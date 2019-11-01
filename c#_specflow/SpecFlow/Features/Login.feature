Feature: Test login feature
  In order to show automation framework
  As a automation user
  I need to create this demo test

  @login
  Scenario: Login selenium demo
    Given I am on "https://staging.contentanalyticsinc.com/"
    When I fill in username with "automation@contentanalyticsinc.com"
    And I fill in password with "dmRv9mR8mKFQ6kcDyxh44u2p"
    And I click on "SignIn"
    Then I should see "Content Health" in title