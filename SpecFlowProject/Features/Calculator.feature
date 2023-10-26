Feature: Calculator
In order to avoid mistakes 
As a math student
I want to use a calculator to add numbers 
Scenario: Add two numbers
Given I have entered 5 into the calculator 
And I have entered 7 into the calculator 
When I press add
Then the result should be 12 on the screen