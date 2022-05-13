Feature: RozetkaTest
	In order to purchase new monitor
	As a Senior QA Test Automation Engineer
	I want to be buy the best monitor on Rozetka
	
@smoke
Scenario Outline: Purchasing most expensive lap top and checking cart page top amount
	Given I entered '<searchText>' in search field
	When I click on search button
	When I choose '<brand>'
	When I sort products from expensive to cheaper
	When I click on buy button
	When I click on cart button
	Then I check summ in bucket '<topAmount>'

Examples:
| searchText | brand | topAmount |
| Монітори   | ASUS  | 79000     |