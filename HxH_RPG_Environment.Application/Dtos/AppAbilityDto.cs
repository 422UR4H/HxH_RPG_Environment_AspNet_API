using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.Application.Dtos;

public class AppAbilityDto(AppExperienceDto exp, AbilityName name)
{
  public AbilityName Name { get; set; } = name;
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