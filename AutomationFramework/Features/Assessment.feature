Feature: 10Pearls Assessment 
	
#Captcha exceptions occurs
Scenario Outline: User should be able to filter Property Listings by Price 
Given User Launches the Application
#And I wait for "5000"
And user is navigation on "//li//a[@data-ui-id='menu-RP']"
And I am clicking on "//li//a[@title='Apartment/Flat for Rent']"
And I am clicking on "//div[@data-testid='price']//button[@data-testid='filter-toggle']//span"
And I have given "60000" on "//div//label[@data-testid='min_price']"
And I have given "80000" on "//div//label[@data-testid='max_price']"
When I am clicking on "//div//button[@data-testid='search']"
#And I wait for "5000"
Then I want to validate filters of price range on "//div[@data-testid='listing-price']//span[2]"
And I Scroll Down 
And I am clicking on "//div//a[@data-test='pagination-page-2']"
#And I wait for "5000"
Then I want to validate filters of price range on "//div[@data-testid='listing-price']//span[2]"





Scenario Outline: Validating Price Range filter
Given User Launches the Application
And I wait for "5000"
And I am clicking on "//div[@data-testid='price']//button[@data-testid='filter-toggle']//span"
And I have given "60000" on "//div//label[@data-testid='min_price']"
And I have given "80000" on "//div//label[@data-testid='max_price']"
When I am clicking on "//div//button[@data-testid='search']"
And I wait for "5000"
Then I want to validate filters of price range on "//div[@data-testid='listing-price']//span[2]"
And I Scroll Down 
And I am clicking on "//div//a[@data-test='pagination-page-2']"
And I wait for "5000"
Then I want to validate filters of price range on "//div[@data-testid='listing-price']//span[2]"




Scenario Outline: Validating location filter
Given User Launches the Application
And I wait for "5000"
And I have given "Dubai Marina" on "//input[@data-testid='input_location']"
When I am clicking on "//div//button[@data-testid='search']"
