Feature: Saucedemo

  Scenario: Purchase
    Given application URL is opened
    And user entered "standard_user" into "Username"
    And user entered "secret_sauce" into "Password"
    And user clicked on "Login button"
    And user clicked on "Add Backpack to Cart"
    And user clicked on "Shopping Cart Link"
    And user clicked on "Checkout"
    And user entered "Lorem" into "First Name"
    And user entered "Ipsum" into "Last Name"
    When user enters "123" into "Postal Code"
    And user clicks on "Continue Button"
    And user clicks on "Finish Button"
    Then the "Title" text should be "Checkout: Complete!"

  Scenario: Elements quantity
    Given application URL is opened
    And user entered "standard_user" into "Username"
    And user entered "secret_sauce" into "Password"
    When user clicks on "Login button"
    Then the "Items" list should have "6" items



