Feature: Test login feature
  In order to show automation framework
  As a automation user
  I need to create this demo test

  Scenario: Login selenium demo
    Given I am on "/"
    When I fill in "UserName" with "automation@contentanalyticsinc.com"
    And I fill in "Password" with "dmRv9mR8mKFQ6kcDyxh44u2p"
    And I click on "SIGN IN"
    Then I should see "CONTENT HEALTH"
