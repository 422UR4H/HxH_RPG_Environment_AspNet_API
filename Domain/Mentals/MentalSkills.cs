using HxH_RPG_Environment.Domain.Experiences;
using HxH_RPG_Environment.Domain.Skills;
using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.Domain.Mentals;

public class MentalSkills : ICascadeUpgrade, IEndCascadeUpgrade
{
  private const double COEFFICIENT = 2.0;
  private readonly Dictionary<SkillName, ISkill> skills = [];
  public Experience Exp { get; private init; }
  public ICascadeUpgrade MentalAbilityExp { get; private init; }

  public MentalSkills(
    Experience mentalSkillsExp,
    Dictionary<AttributeName, ICascadeUpgrade> mentalAttributeExp,
    ICascadeUpgrade mentalAbilityExp)
  {
    Exp = mentalSkillsExp;
    MentalAbilityExp = mentalAbilityExp;

    Experience skillExp = new(new ExpTable(COEFFICIENT));
    // PersonSkill skill = new(skillExp, mentalAttributeExp, this);

    // skills.Add(SkillName., skill.Clone());
  }

  // TODO: refactor this exception
  public ISkill Get(SkillName name)
  {
    return skills.GetValueOrDefault(name) ??
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
    MentalAbilityExp.CascadeUpgrade(exp);
  }

  public void TriggerEndUpgrade(int exp)
  {
    Exp.IncreasePoints(exp);
  }
}