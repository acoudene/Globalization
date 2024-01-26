// Changelogs Date  | Author                | Description
// 2023-12-23       | Anthony Coudène       | Creation

namespace UseCase.Data.MongoDb.Entities;

public static class MyInformationMongoEntityExtensions
{
  public static MyInformationMongo ToMongo(this MyInformation entity)
  {
    return new MyInformationMongo()
    {
      Id = entity.Id,

      // TODO - EntityMapping - Business Entity to Mongo Entity to complete
      CreationDateUtc = entity.CreationDate.UtcDateTime,
      CreationDateUtcDoc = entity.CreationDate.UtcDateTime,
      CreationDateOffSet = entity.CreationDate
    };
  }

  public static MyInformation ToEntity(this MyInformationMongo mongoEntity)
  {
    return new MyInformation()
    {
      Id = mongoEntity.Id,

      // TODO - EntityMapping - Mongo Entity to Business Entity to complete
      CreationDate = mongoEntity.CreationDateUtcDoc
    };
  }
}
