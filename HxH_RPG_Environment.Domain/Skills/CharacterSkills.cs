using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.Domain.Skills;

public class CharacterSkills(
  SkillsManager physicalSkills,
  SkillsManager mentalSkills,
  SkillsManager spiritualSkills)
{
  public SkillsManager PhysicalSkills { get; } = physicalSkills;
  public SkillsManager MentalSkills { get; } = mentalSkills;
  public SkillsManager SpiritualSkills { get; } = spiritualSkills;

  // TODO: refactor this exception
  public ISkill Get(SkillName name)
  {
    return SpiritualSkills.Get(name) ??
      PhysicalSkills.Get(name) ??
      MentalSkills.Get(name) ??
      throw new Exception("Skill not found!");
  }

  public int GetValueForTestOf(SkillName name)
  {
    return Get(name).GetValueForTest();
  }

  public int GetExpPointsOf(SkillName name)
  {
    return Get(name).GetExpPoints();
  }

  public int GetLevelOf(SkillName name)
  {
    return Get(name).GetLvl();
  }

  public int IncreaseExp(int points, SkillName name)
  {
    return Get(name).IncreaseExp(points);
  }
}