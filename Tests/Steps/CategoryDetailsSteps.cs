using api_basic_dotnet.DataModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using Shouldly;
using System.Net;

namespace api_basic_dotnet.Tests.Steps;
[Binding]
internal class CategoryDetailsSteps
{
    private RestResponse? response;
    private CategoryDetailsResponse? actualCategoryDetailsResponse;
    private readonly string? baseURL = "https://api.tmsandbox.co.nz";

    [When(@"I perform a GET request to the following endpoint '([^']*)'")]
    public async Task WhenIPerformARequestToTheFollowingEndpoint(string p1)
    {
        var options = new RestClientOptions(baseURL);
        var client = new RestClient(options);
        var request = new RestRequest(p1, Method.Get);
        response = await client.ExecuteAsync(request);
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
    }

    [Then(@"I receive a valid payload")]
    public void ThenIReceiveAValidPayload()
    {
        actualCategoryDetailsResponse = JsonConvert.DeserializeObject<CategoryDetailsResponse>(response!.Content!);
    }

    [Then(@"the following data is returned")]
    public void ThenTheFollowingDataIsReturned(Table table)
    {
        JToken jsonRepresentation = JToken.FromObject(actualCategoryDetailsResponse!);
        table.Rows.ToList().ForEach(row =>
        {
            var jsonPath = row["jsonPath"];
            var exactMatch = Boolean.Parse(row["exactMatch"]);
            var expectedContent = row["expectedContent"];

            var element = jsonRepresentation.SelectToken(jsonPath);
            if (exactMatch)
                element!.Value<string>().ShouldBe(expectedContent);
            else
                element!.Value<string>()!.ShouldContain(expectedContent);
        });
    }

}

