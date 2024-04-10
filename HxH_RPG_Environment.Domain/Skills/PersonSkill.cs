using HxH_RPG_Environment.Domain.Attributes;
using HxH_RPG_Environment.Domain.Experiences;

namespace HxH_RPG_Environment.Domain.Skills;

public class PersonSkill(
  Experience exp,
  IGameAttribute attribute,
  IEndCascadeUpgrade abilitySkillsExp) : ISkill
{
  public Experience Exp { get; } = exp;
  public IGameAttribute Attribute { get; } = attribute;
  public IEndCascadeUpgrade AbilitySkillsExp { get; } = abilitySkillsExp;

  public virtual void TriggerCascadeUpgrade(int exp)
  {
    Exp.IncreasePoints(exp);
    Attribute.CascadeUpgrade(exp);
    AbilitySkillsExp.TriggerEndUpgrade(exp);
  }

  public int GetLvl()
  {
    return Exp.GetLvl();
  }

  public int GetValueForTest()
  {
    return Exp.GetLvl() + Attribute.GetPower();
  }

  public PersonSkill Clone()
  {
    return new PersonSkill(Exp.Clone(), Attribute, AbilitySkillsExp);
  }
}