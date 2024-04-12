using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.API.Dtos;

public class NenPrincipleDto(NenPrincipleName name, ExperienceDto exp)
{
  public NenPrincipleName Name { get; set; } = name;
  public ExperienceDto Exp { get; set; } = exp;
}