using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.API.Dtos;

public class SkillsDto(SkillName name, ExperienceDto exp)
{
  public SkillName Name { get; set; } = name;
  public ExperienceDto Exp { get; set; } = exp;
}