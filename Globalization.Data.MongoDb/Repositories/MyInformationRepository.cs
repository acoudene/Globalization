// Changelogs Date  | Author                | Description
// 2023-12-23       | Anthony Coudène       | Creation

namespace UseCase.Data.MongoDb.Repositories;

public class MyInformationRepository : MongoRepositoryBase<MyInformation, MyInformationMongo>
  , IMyInformationRepository
{
  public const string CollectionName = "myInformation";

  public MyInformationRepository(IMongoContext mongoContext)
    : base(mongoContext, CollectionName)
  { 
  }

  protected override MyInformation MapToEntity(MyInformationMongo mongoEntity)
  {
    return mongoEntity.ToEntity();
  }

  protected override MyInformationMongo MapToMongoEntity(MyInformation entity)
  {
    return entity.ToMongo();
  }
}
