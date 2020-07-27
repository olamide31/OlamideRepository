Feature: Datadrivenwithparameters
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: data driven with parameters
	Given I navigate to "https://angularjs.realworld.io/#/register"
	When I enter my username text "maldives"
	And i enter my email text "maldives2020"
	And i enter password text "password222"
	#And i click on sign up button
	#Then i am logged in with my username displayed
