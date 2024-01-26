using System.Collections;

namespace Globalization.Host.Tests;

internal class MyInformationData : IEnumerable<object[]>
{
  public IEnumerator<object[]> GetEnumerator()
  {
    yield return new object[] 
    {
      new MyInformationDto()
      {
        Id = Guid.NewGuid(),
        // TODO - EntityProperties - Fields to complete
        CreationDate = DateTime.Now
      }
    };
    yield return new object[]
    {
      new MyInformationDto()
      {
        Id = Guid.NewGuid(),
        // TODO - EntityProperties - Fields to complete
        CreationDate = DateTime.Now.AddHours(-1)
      }
    };
    yield return new object[]
    {
      new MyInformationDto()
      {
        Id = Guid.NewGuid(),
        // TODO - EntityProperties - Fields to complete
        CreationDate = DateTime.Now.AddHours(-2)
      }
    };
  }
  
  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

