// Changelogs Date  | Author                | Description
// 2023-12-23       | Anthony Coudène       | Creation

namespace UseCase.Data.Entities;

public record MyInformation : IIdentifierEntity
{
  public Guid Id { get; set; }

  // TODO - EntityProperties - Fields to complete
  public DateTimeOffset CreationDate { get; set; }
}