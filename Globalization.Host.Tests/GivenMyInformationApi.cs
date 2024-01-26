// Changelogs Date  | Author                | Description
// 2023-12-23       | Anthony Coudène       | Creation

using Globalization.Host.Tests;

namespace UseCase.Host.Tests;

/// WARNING - for the moment, I don't have found a solution to reset settings like connexion string on a static test server
/// So be careful when changing settings, the same first settings will remain for server for all tests in this class even if this container is reset.
/// For example, don't change default port to reuse the same.
public class GivenMyInformationApi : HostApiMongoTestBase<Program>
{
  public GivenMyInformationApi(
    WebApplicationFactory<Program> webApplicationFactory,
    ITestOutputHelper output)
    : base("myInformation", webApplicationFactory, output)
  {
  }

  private const string ApiPath = "/api";
  private const string ApiRelativePath = $"{ApiPath}/MyInformation/"; // Warning, this ending slash is important in HttpClientFactory... :(

  [Theory]
  [ClassData(typeof(MyInformationData))]
  public async Task WhenCreatingItem_ThenSingleItemIsCreatedAsync(MyInformationDto givenItem)
  {
    // Arrange
    var httpClientFactory = CreateHttpClientFactory(ApiRelativePath);
    var client = new HttpMyInformationClient(httpClientFactory);

    // Act
    HttpResponseMessage response = await client.CreateAsync(givenItem, false);

    // Assert    
    Assert.Null(Record.Exception(() =>
    {
      if (!response.IsSuccessStatusCode)
        OutputHelper.WriteLine(response.Content.ReadAsStringAsync().Result);
      response.EnsureSuccessStatusCode();
    }));

    var receivedItem = await client.GetByIdAsync(givenItem.Id);
    Assert.NotNull(receivedItem);
    Assert.Equal(givenItem.CreationDate.ToLocalTime(), receivedItem.CreationDate.ToLocalTime());
    Assert.Equal(givenItem.CreationDate.ToUniversalTime(), receivedItem.CreationDate.ToUniversalTime());
  }

  [Theory]
  [ClassData(typeof(MyInformationsData))]
  public async Task WhenCreatingItems_ThenAllItemsAreGot_Async(List<MyInformationDto> givenItems)
  {
    // Arrange
    var httpClientFactory = CreateHttpClientFactory(ApiRelativePath);
    var client = new HttpMyInformationClient(httpClientFactory);
    foreach (var item in givenItems)
      await WhenCreatingItem_ThenSingleItemIsCreatedAsync(item);
    var ids = givenItems.Select(item => item.Id).ToList();
    int expectedCount = givenItems.Count;

    // Act
    var receivedItems = (await client.GetByIdsAsync(ids));

    // Assert
    Assert.True(givenItems is not null && expectedCount == givenItems.Count);
    Assert.Equivalent(givenItems.Select(item=>item.Id), receivedItems.Select(item=>item.Id));
  }

}
