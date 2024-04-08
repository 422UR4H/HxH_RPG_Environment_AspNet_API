using HxH_RPG_Environment.Domain.Enums;
using HxH_RPG_Environment.Domain.Experiences;

namespace HxH_RPG_Environment.Domain.Skills;

public class SkillsManager(
  Experience exp,
  ICascadeUpgrade skillsExp,
  ICascadeUpgrade abilityExp) : ICascadeUpgrade, IEndCascadeUpgrade
{
  public Dictionary<SkillName, ISkill> Skills { get; private set; } = [];
  public Experience Exp { get; } = exp;
  public ICascadeUpgrade SkillsExp { get; } = skillsExp;
  public ICascadeUpgrade AbilityExp { get; } = abilityExp;

  public void Init(Dictionary<SkillName, ISkill> skills)
  {
    if (Skills.Count > 0)
    {

      Console.WriteLine("Skills already initialized!");
      return;
    }
    Skills = skills;
  }

  // TODO: refactor this exception
  public ISkill? Get(SkillName name)
  {
    return Skills.GetValueOrDefault(name);
  }

  public int GetLvlOf(SkillName name)
  {
    return Get(name)?.GetLvl() ??
      throw new Exception("Skill not found!");
  }

  public int GetValueForTestOf(SkillName name)
  {
    return Get(name)?.GetValueForTest() ??
      throw new Exception("Skill not found!");
  }

  public void CascadeUpgrade(int exp)
  {
    Exp.IncreasePoints(exp);
    SkillsExp.CascadeUpgrade(exp);
    AbilityExp.CascadeUpgrade(exp);
  }

  public void TriggerEndUpgrade(int exp)
  {
    Exp.IncreasePoints(exp);
  }
}