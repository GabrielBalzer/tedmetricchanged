Feature: Gmail Login

  Scenario: Login
    Given Chrome is started
    And Chrome is maximized
    And Gmail is opened
    When I enter my username
    And  I enter my password
    And I click login
    Then the page title should start with "Webmail"