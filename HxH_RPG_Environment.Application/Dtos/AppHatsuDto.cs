using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.Application.Dtos;

public class AppHatsuDto(
  AppExperienceDto exp,
  AppNenCategoryDto[] categories)
{
  public AppExperienceDto Exp { get; set; } = exp;
  public AppNenCategoryDto[] Categories { get; set; } = categories;

  // TODO: refactor this exception
  public AppNenCategoryDto Get(NenCategoryName name)
  {
    return Categories.FirstOrDefault(a => a.Name == name) ??
      throw new Exception("Nen Category not found!");
  }

  public int GetExpPointsOf(NenCategoryName name)
  {
    return Get(name).GetExpPoints();
  }

  public int GetLevelOf(NenCategoryName name)
  {
    return Get(name).GetLevel();
  }
}