Feature: RegistrationPage

In other for me to take full advantage of the website, I need to become a regsitered User.

@tag1
Scenario: Signing Up
	Given I navigate to the website
	And I click on Sign up
	And I enter my Username
	And I enter my Email
	And I enter my Password
	When I click on Sign up Button
	Then I should be able to Sign up sucessfully
