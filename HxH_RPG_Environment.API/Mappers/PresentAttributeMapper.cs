using HxH_RPG_Environment.API.Dtos;
using HxH_RPG_Environment.Application.Dtos;

namespace HxH_RPG_Environment.API.Mappers;

public class PresentAttributeMapper
{
  public AppAttributeDto ToAppDto(InputAttributeDto dto)
  {
    AppExperienceDto exp = new(dto.GetExpPoints(), dto.GetLevel());
    return new AppAttributeDto(dto.Name, exp, dto.Points);
  }
}