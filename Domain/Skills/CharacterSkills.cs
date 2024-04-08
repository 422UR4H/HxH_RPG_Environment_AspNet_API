using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.Domain.Skills;

public class CharacterSkills(
  SkillsManager physicalSkills,
  SkillsManager mentalSkills)
{
  public SkillsManager PhysicalSkills { get; } = physicalSkills;
  public SkillsManager MentalSkills { get; } = mentalSkills;

  // TODO: refactor this method
  public ISkill Get(SkillName name)
  {
    ISkill skill;
    try
    {
      skill = PhysicalSkills.Get(name);
    }
    catch (Exception)
    {
      skill = MentalSkills.Get(name) ??
        throw new Exception("Skill not found!");
    }
    return skill;
  }

  public int GetValueForTestOf(SkillName name)
  {
    return Get(name).GetValueForTest();
  }
}