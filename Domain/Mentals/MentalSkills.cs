using HxH_RPG_Environment.Domain.Experiences;
using HxH_RPG_Environment.Domain.Skills;
using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.Domain.Mentals;

public class MentalSkills(
  Experience exp,
  ICascadeUpgrade skillsExp,
  ICascadeUpgrade mentalAbilityExp) : ICascadeUpgrade, IEndCascadeUpgrade
{
  public Dictionary<SkillName, ISkill> Skills { get; private set; } = [];
  public Experience Exp { get; private init; } = exp;
  public ICascadeUpgrade SkillsExp { get; private init; } = skillsExp;
  public ICascadeUpgrade MentalAbilityExp { get; private init; } = mentalAbilityExp;

  public void InitSkills(Dictionary<SkillName, ISkill> skills)
  {
    if (skills.Count > 0)
    {
      Console.WriteLine("Skills already initialized!");
      return;
    }
    Skills = skills;
  }

  // TODO: refactor this exception
  public ISkill Get(SkillName name)
  {
    return Skills.GetValueOrDefault(name) ??
      throw new Exception("Skill not found!");
  }

  public int GetLvlOf(SkillName name)
  {
    return Get(name).GetLvl();
  }

  public int GetValueForTestOf(SkillName name)
  {
    return Get(name).GetValueForTest();
  }

  public void CascadeUpgrade(int exp)
  {
    Exp.IncreasePoints(exp);
    SkillsExp.CascadeUpgrade(exp);
    MentalAbilityExp.CascadeUpgrade(exp);
  }

  public void TriggerEndUpgrade(int exp)
  {
    Exp.IncreasePoints(exp);
  }
}