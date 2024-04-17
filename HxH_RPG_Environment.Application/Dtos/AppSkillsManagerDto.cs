using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.Application.Dtos;

public class AppSkillsManagerDto(
  AppExperienceDto exp,
  AppSkillDto[] skills)
{
  public AppExperienceDto Exp { get; set; } = exp;
  public AppSkillDto[] Skills { get; set; } = skills;

  // TODO: refactor this exception
  public AppSkillDto Get(SkillName name)
  {
    return Skills.FirstOrDefault(a => a.Name == name) ??
      throw new Exception("Skill not found!");
  }
}