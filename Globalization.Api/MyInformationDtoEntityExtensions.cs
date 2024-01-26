// Changelogs Date  | Author                | Description
// 2023-12-23       | Anthony Coudène       | Creation

using Core.Data;

namespace UseCase.Api;

public static class MyInformationDtoEntityExtensions
{
  public static MyInformationDto ToDto(this MyInformation entity)
  {
    return new MyInformationDto()
    {
      Id = entity.Id,

      // TODO - EntityMapping - Business Entity to Dto to complete
      CreationDate = entity.CreationDate
    };
  }

  public static MyInformation ToEntity(this MyInformationDto dto)
  {
    return new MyInformation()
    {
      Id = dto.Id,

      // TODO - EntityMapping - Dto to Business Entity to complete
      CreationDate = dto.CreationDate
    };
  }
}
