using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.Application.Dtos;

public class AppAttributeDto(AttributeName name, AppExperienceDto exp, int points)
{
  public AttributeName Name { get; set; } = name;
  public AppExperienceDto Exp { get; set; } = exp;
  public int Points { get; set; } = points;

  public int GetExpPoints()
  {
    return Exp.Points;
  }

  public int GetLevel()
  {
    return Exp.Level;
  }
}