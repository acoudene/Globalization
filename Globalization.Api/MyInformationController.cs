// Changelogs Date  | Author                | Description
// 2023-12-23       | Anthony Coudène       | Creation

namespace UseCase.Api;

[ApiController]
[Route("api/[controller]")]
public class MyInformationController : RestControllerBase<MyInformationDto, MyInformation, IMyInformationRepository>
{
  public MyInformationController(IMyInformationRepository repository)
    : base(repository)
  {

  }

  protected override MyInformationDto ToDto(MyInformation entity)
    => entity.ToDto();

  protected override MyInformation ToEntity(MyInformationDto dto)
    => dto.ToEntity();
}
