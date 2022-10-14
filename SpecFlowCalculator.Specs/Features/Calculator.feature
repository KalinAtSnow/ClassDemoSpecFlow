Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowCalculator.Specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

@multiply
Scenario: Multiply two numbers
	Given the first number is 2
	And the second number is 3
	When the two numbers are multiplied
	Then the result should be 6

@string
Scenario: test for string
	Given the first string is a string 'asdf'
	And the second string is 'ghij'
	When the two numbers are added
	Then the result should be 0
	#should probably throw error here as well

@subtraction
Scenario: Test basic subtraction
	Given the first number is 10
	And the second number is 5
	When the two numbers are subtracted
	Then the result should be 5

@subtraction
Scenario: Test big subtraction from small number
	Given the first number is 5
	And the second number is 10
	When the two numbers are subtracted
	Then the result should be -5

@subtraction
Scenario: Test subtracting a negative
	Given the first number is 10
	And the second number is -10
	When the two numbers are subtracted
	Then the result should be 20

@division
Scenario: Test basic division
	Given the first number is 50
	And the second number is 10
	When the two numbers are divided
	Then the result should be 5

@division
Scenario: Test division by zero
	Given the first number is 50
	And the second number is 0
	When the two numbers are divided
	Then the result should be 0
	# it should be an error but I'm not sure on how to throw an error in gherkin

@multiOp
Scenario: Test for multiple operations in a row
	Given the first number is 15
	And the operation + is done with 20
	And the operation - is done with 10
	And the operation - is done with 5
	Then the result should be 20

@multiOp
Scenario: Test for multiple operations including multiplication and division
	Given the first number is 2
	And the operation * is done with 8
	And the operation / is done with 4
	And the operation - is done with 3
	Then the result should be 1