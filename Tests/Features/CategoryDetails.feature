Feature: CategoryDetails

API endpoint: 
/v1/Categories/:id/Details.json

Provides detail information about categories within API at https://api.tmsandbox.co.nz

Scenario: Positive - Get Category Details
	When I perform a GET request to the following endpoint '/v1/Categories/6327/Details.json?catalogue=false'
	Then I receive a valid payload
	And the following data is returned
		| jsonPath                  | exactMatch | expectedContent           |
		| Name                      | true       | Carbon credits            |
		| CanRelist                 | true       | True                      |
		| Promotions[1].Name        | true       | Gallery                   |
		| Promotions[1].Description | false      | Good position in category |
