using HxH_RPG_Environment.Domain.Experiences;

namespace HxH_RPG_Environment.Domain.Skills;

public class PersonSkill(
  Experience exp,
  ICascadeUpgrade attributeExp,
  IEndCascadeUpgrade abilitySkillsExp) : ISkill
{
  public Experience Exp { get; } = exp;
  public ICascadeUpgrade AttributeExp { get; } = attributeExp;
  public IEndCascadeUpgrade AbilitySkillsExp { get; } = abilitySkillsExp;

  public void TriggerCascadeUpgrade(int exp)
  {
    Exp.IncreasePoints(exp);
    AttributeExp.CascadeUpgrade(exp);
    AbilitySkillsExp.TriggerEndUpgrade(exp);
  }

  public PersonSkill Clone()
  {
    return new PersonSkill(Exp.Clone(), AttributeExp, AbilitySkillsExp);
  }
}