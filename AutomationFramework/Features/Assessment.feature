Feature: 10Pearls Assessment 
	

#@mytag
#Scenario: Add two numbers
#	Given the first number is 50
#	And the second number is 70
#	When the two numbers are added
#	Then the result should be 120

Scenario Outline: User should be able to filter Property Listings by Price 
Given User Launches the Application
And I wait for "5000"
And user is navigation on "//li//a[@data-ui-id='menu-RP']"
And I am clicking on "//li//a[@title='Apartment/Flat for Rent']"




Scenario Outline: testing
Given User Launches the Application
And I wait for "5000"
And I am clicking on "//div[@data-testid='price']//button[@data-testid='filter-toggle']//span"
And I have given "60000" on "//div//label[@data-testid='min_price']"
And I have given "80000" on "//div//label[@data-testid='max_price']"
When I am clicking on "//div//button[@data-testid='search']"
And I wait for "5000"
Then I want to validate filters of price range on "//div[@data-testid='listing-price']//span[2]"


