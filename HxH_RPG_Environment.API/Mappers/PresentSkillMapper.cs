using HxH_RPG_Environment.API.Dtos;
using HxH_RPG_Environment.Application.Dtos;

namespace HxH_RPG_Environment.API.Mappers;

public class PresentSkillMapper
{
  public AppSkillDto ToAppDto(InputSkillDto dto)
  {
    AppExperienceDto exp = new(dto.GetExpPoints(), dto.GetLevel());
    return new AppSkillDto(dto.Name, exp);
  }
}