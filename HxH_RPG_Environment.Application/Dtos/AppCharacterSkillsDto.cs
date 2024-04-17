using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.Application.Dtos;

public class AppCharacterSkillsDto(
  AppSkillsManagerDto physicSkills,
  AppSkillsManagerDto mentalSkills,
  AppSkillsManagerDto spiritSkills)
{
  public AppSkillsManagerDto PhysicSkills { get; set; } = physicSkills;
  public AppSkillsManagerDto MentalSkills { get; set; } = mentalSkills;
  public AppSkillsManagerDto SpiritSkills { get; set; } = spiritSkills;

  // TODO: refactor this exception
  public AppSkillDto Get(SkillName name)
  {
    return SpiritSkills.Get(name) ??
      PhysicSkills.Get(name) ??
      MentalSkills.Get(name) ??
      throw new Exception("Skill not found!");
  }

  public int GetExpPointsOf(SkillName name)
  {
    return Get(name).GetExpPoints();
  }

  public int GetLevelOf(SkillName name)
  {
    return Get(name).GetLevel();
  }
}