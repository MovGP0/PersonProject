Feature: Person
	In order to save person date

Scenario Outline: Create a person
	Given I have created a person with FirstName <FirstName> and LastName <LastName>
	Then the FirstName must be <FirstName>
	And the LastName must be <LastName>
	Examples: 
		| FirstName | LastName |
		| Hubert    | Meyer    |
		| Andrä     | Heller   |
		| Chäsar    | Zeppelin | 

Scenario: Throw an exception when creating a person without firstName
	Given I have created a person without firstName and LastName <LastName>
	Then an ArgumentNullException must be thrown
	Examples: 
		| FirstName | LastName |
		| Hubert    | Meyer    |
		| Andrä     | Heller   |
		| Chäsar    | Zeppelin | 

Scenario: Throw an exception when creating a person with empty firstName
	Given I have created a person with empty firstName and LastName <LastName>
	Then an ArgumentNullException must be thrown
	Examples: 
		| FirstName | LastName |
		| Hubert    | Meyer    |
		| Andrä     | Heller   |
		| Chäsar    | Zeppelin | 
