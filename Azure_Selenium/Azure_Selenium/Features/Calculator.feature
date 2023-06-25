Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](Azure_Selenium/Features/Calculator.feature)
***Further read***: *testing tests branch*[sssLearn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag@mytags
Scenario: Add two numbers
	Given the first number is 500
	And the second number is 70
	When the two numbers are added
	Then the result should be 1250