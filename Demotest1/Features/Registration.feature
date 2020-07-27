Feature: Registration
	In order to use the angularjs website
	i will need to register
	so i can enjoy the benefits

@mytag
Scenario: valid Registration
	Given I navigate to angularjs website
	When I clicked on sign up
	And i enter my username
	And i enter my email
	And i enter my password
	And i click on sign up to angularjs
	Then my account should be created

	
	
