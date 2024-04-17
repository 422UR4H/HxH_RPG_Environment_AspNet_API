using HxH_RPG_Environment.API.Dtos;
using HxH_RPG_Environment.Application.Dtos;

namespace HxH_RPG_Environment.API.Mappers;

public class PresentAbilityMapper
{
  public AppAbilityDto ToAppDto(InputAbilityDto dto)
  {
    AppExperienceDto exp = new(dto.GetExpPoints(), dto.GetLevel());
    return new AppAbilityDto(exp, dto.Name);
  }
}