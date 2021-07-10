Feature: 10Pearls Assessment 
	

#@mytag
#Scenario: Add two numbers
#	Given the first number is 50
#	And the second number is 70
#	When the two numbers are added
#	Then the result should be 120

Scenario Outline: User should be able to filter Property Listings by Price 
Given User Launches the Application
And user is navigation on "//li//a[@data-fnid='category_property-for-rent']"