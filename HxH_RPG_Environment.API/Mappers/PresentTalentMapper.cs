using HxH_RPG_Environment.API.Dtos;
using HxH_RPG_Environment.Application.Dtos;

namespace HxH_RPG_Environment.API.Mappers;

public class PresentTalentMapper
{
  public AppTalentDto ToAppDto(InputTalentDto dto)
  {
    AppExperienceDto exp = new(dto.GetExpPoints(), dto.GetLevel());
    return new AppTalentDto(exp);
  }
}