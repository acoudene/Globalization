// Changelogs Date  | Author                | Description
// 2023-12-23       | Anthony Coudène       | Creation

namespace UseCase.Proxies;

public class HttpMyInformationClient : HttpRestClientBase<MyInformationDto>, IMyInformationClient
{
  /// <summary>
  /// Constructor
  /// </summary>
  /// <param name="httpClientFactory"></param>
  /// <exception cref="ArgumentNullException"></exception>
  public HttpMyInformationClient(IHttpClientFactory httpClientFactory)
    : base(httpClientFactory)
  {
  }

  public const string ConfigurationName = nameof(HttpMyInformationClient);

  public override string GetConfigurationName() => ConfigurationName;
}
