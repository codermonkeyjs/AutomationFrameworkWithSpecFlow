Feature: SignUp

A short summary of the feature

@tag1
Scenario: Sign Up
	Given I navigate to the website
	And I enter username
	And I enter password
	And I enter email
	When I click the submit button
	Then I should be able to sign up and sign in
