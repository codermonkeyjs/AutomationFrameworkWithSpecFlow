Feature: SignUp

In order to sign up, I need to enter my username, email and password. 
Clicking the submit button should sign me up successfully.

@tag1
Scenario: Sign Up
	Given I navigate to the website
	And I enter username
	And I enter password
	And I enter email
	When I click the submit button
	Then I should be able to sign up and sign in
