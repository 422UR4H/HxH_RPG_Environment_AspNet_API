using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.Application.Dtos;

public class AppNenCategoryDto(NenCategoryName name, AppExperienceDto exp)
{
  public NenCategoryName Name { get; set; } = name;
  public AppExperienceDto Exp { get; set; } = exp;

  public int GetExpPoints()
  {
    return Exp.Points;
  }

  public int GetLevel()
  {
    return Exp.Level;
  }
}