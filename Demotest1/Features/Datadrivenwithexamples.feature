Feature: Datadrivenwithexamples
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: Data Driven With Examples
	Given I navigate to "https://angularjs.realworld.io/#/register"
	When the user enter username text "<Nasty>"
	And the user enter email text "<Elephant>"
	And the user enter password text "<Pigeon>"
	#And i click on sign up button
	#Then i am logged in with my username displayed

	Examples:

	| Nasty     | Elephant   | Pigeon      |
	| maldives  | maldives20 | password222 |
	| maldives2 | maldives20 | password111 |


