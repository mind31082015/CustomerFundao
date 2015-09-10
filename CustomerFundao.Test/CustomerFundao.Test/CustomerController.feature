Feature: CustomerController
	Obtem todos os clientes ativos 

@Customer
Scenario: Get all active customers
	Given I have a Customer Controller With Index Action
	When I Request All Customers
	Then the I should receive a json object
