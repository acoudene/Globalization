// Changelogs Date  | Author                | Description
// 2023-12-23       | Anthony Coudène       | Creation

namespace UseCase.Data.MongoDb.Entities;

[BsonIgnoreExtraElements]
public record MyInformationMongo : IIdentifierMongoEntity
{
  [BsonId]
  [BsonElement("_id")]
  [BsonRepresentation(representation: BsonType.ObjectId)]
  [BsonIgnoreIfDefault]
  public ObjectId ObjectId { get; set; }

  [BsonElement("uuid")]
  [BsonGuidRepresentation(GuidRepresentation.Standard)]
  public required Guid Id { get; set; }

  // TODO - EntityProperties - Fields to complete
  [BsonDateTimeOptions(Kind = DateTimeKind.Utc, Representation =BsonType.Document)]
  public DateTime CreationDateUtcDoc { get; set; }

  [BsonDateTimeOptions(Kind = DateTimeKind.Utc, Representation = BsonType.DateTime)]
  public DateTime CreationDateUtc { get; set; }
  
  public DateTimeOffset CreationDateOffSet { get; set; }
}