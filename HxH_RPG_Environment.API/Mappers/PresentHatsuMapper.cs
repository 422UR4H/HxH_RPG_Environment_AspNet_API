using HxH_RPG_Environment.API.Dtos;
using HxH_RPG_Environment.Application.Dtos;

namespace HxH_RPG_Environment.API.Mappers;

public class PresentHatsuMapper(
  PresentNenCategoryMapper categoryMapper,
  PresentExperienceMapper expMapper)
{
  private readonly PresentNenCategoryMapper _categoryMapper = categoryMapper;
  private readonly PresentExperienceMapper _expMapper = expMapper;

  public AppHatsuDto ToAppDto(InputHatsuDto dto)
  {
    ICollection<AppNenCategoryDto> categories = [];
    foreach (var c in dto.Categories)
    {
      categories.Add(_categoryMapper.ToAppDto(c));
    }
    return new AppHatsuDto(_expMapper.ToAppDto(dto.Exp), [.. categories]);
  }
}