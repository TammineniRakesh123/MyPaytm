Feature: PaytmScenario
	To test if the paytm website has all the elements present 
	And to validate the mobile page

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen
