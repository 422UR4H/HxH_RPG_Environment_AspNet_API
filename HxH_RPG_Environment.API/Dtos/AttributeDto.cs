using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.API.Dtos;

public class AttributeDto(AttributeName name, ExperienceDto exp, int points)
{
  public AttributeName Name { get; set; } = name;
  public ExperienceDto Exp { get; set; } = exp;
  public int Points { get; set; } = points;
}