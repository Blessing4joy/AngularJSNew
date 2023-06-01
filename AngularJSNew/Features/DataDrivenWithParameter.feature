Feature: DataDrivenWithParameter

In order to take full advantage of the website,i need to sign up

@tag1
Scenario: Signing Up
	Given I navigate to "https://angularjs.realworld.io/#/"
	And I click on Sign up
	And I enter my Username text "JASON"
	And I enter my Email text "jason24@ymail.com"
	And I enter my Password text "jason2134"
	When I click on Sign up Button
	Then I should be able to Sign up sucessfully
