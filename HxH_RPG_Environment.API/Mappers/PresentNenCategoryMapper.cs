using HxH_RPG_Environment.API.Dtos;
using HxH_RPG_Environment.Application.Dtos;

namespace HxH_RPG_Environment.API.Mappers;

public class PresentNenCategoryMapper
{
  public AppNenCategoryDto ToAppDto(InputNenCategoryDto dto)
  {
    AppExperienceDto exp = new(dto.GetExpPoints(), dto.GetLevel());
    return new AppNenCategoryDto(dto.Name, exp);
  }
}