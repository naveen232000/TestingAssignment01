Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](TestingAssignment01/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

Scenario: Sub two numbers
	Given the first number is 5
	And the second number is 5
	When the two numbers are subrt
	Then the result should be 0

Scenario: Multi two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are multi
	Then the result should be 3500

Scenario: Divid two numbers
	Given the first number is 25
	And the second number is 5
	When the two numbers are divid
	Then the result should be 5