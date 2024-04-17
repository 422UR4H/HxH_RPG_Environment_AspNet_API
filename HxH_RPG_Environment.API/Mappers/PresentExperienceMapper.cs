using HxH_RPG_Environment.API.Dtos;
using HxH_RPG_Environment.Application.Dtos;

namespace HxH_RPG_Environment.API.Mappers;

public class PresentExperienceMapper
{
  public AppExperienceDto ToAppDto(InputExperienceDto dto)
  {
    return new AppExperienceDto(dto.Points, dto.Level);
  }
}