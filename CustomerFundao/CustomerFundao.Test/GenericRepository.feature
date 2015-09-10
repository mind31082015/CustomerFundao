Feature: GenericRepository

@GenericRepository
Scenario: Create an entity
	Given A Context
	And I add a entity
	When Fetch all results
	Then I got 1 entity
