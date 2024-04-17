using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.Application.Dtos;

public class AppNenPrincipleDto(NenPrincipleName name, AppExperienceDto exp)
{
  public NenPrincipleName Name { get; set; } = name;
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