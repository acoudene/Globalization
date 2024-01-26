using System.Collections;

namespace Globalization.Host.Tests;

internal class MyInformationsData : IEnumerable<object[]>
{
  public IEnumerator<object[]> GetEnumerator()
  {
    yield return new object[]
    {
      new List<MyInformationDto>()
      {
        new MyInformationDto()
        {
          Id = Guid.NewGuid(),
          // TODO - EntityProperties - Fields to complete
          CreationDate = DateTime.Now
        },
        new MyInformationDto()
        {
          Id = Guid.NewGuid(),
          // TODO - EntityProperties - Fields to complete
          CreationDate = DateTime.Now.AddHours(-1)
        }
      }
    };
    yield return new object[]
    {
      new List<MyInformationDto>()
      {
        new MyInformationDto()
        {
          Id = Guid.NewGuid(),
          // TODO - EntityProperties - Fields to complete
          CreationDate = DateTime.Now
        },
        new MyInformationDto()
        {
          Id = Guid.NewGuid(),
          // TODO - EntityProperties - Fields to complete
          CreationDate = DateTime.Now.AddHours(-2)
        }
      }
    };
    yield return new object[]
    {
      new List<MyInformationDto>()
      {
        new MyInformationDto()
        {
          Id = Guid.NewGuid(),
          // TODO - EntityProperties - Fields to complete
          CreationDate = DateTime.Now
        },
        new MyInformationDto()
        {
          Id = Guid.NewGuid(),
          // TODO - EntityProperties - Fields to complete
          CreationDate = DateTime.Now.AddHours(-3)
        }
      }
    };
  }
  
  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

