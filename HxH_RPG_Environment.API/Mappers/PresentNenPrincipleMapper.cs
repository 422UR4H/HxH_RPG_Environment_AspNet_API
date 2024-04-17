using HxH_RPG_Environment.API.Dtos;
using HxH_RPG_Environment.Application.Dtos;

namespace HxH_RPG_Environment.API.Mappers;

public class PresentNenPrincipleMapper
{
  public AppNenPrincipleDto ToAppDto(InputNenPrincipleDto dto)
  {
    AppExperienceDto exp = new(dto.GetExpPoints(), dto.GetLevel());
    return new AppNenPrincipleDto(dto.Name, exp);
  }
}