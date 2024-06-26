using HxH_RPG_Environment.Domain.Experiences;

namespace HxH_RPG_Environment.Domain.Spirituals;

public class NenPrinciple(
  Experience exp,
  ICascadeUpgrade abilityExp) : IPrinciple, ITriggerCascadeExp
{
  public Experience Exp { get; } = exp;
  public ICascadeUpgrade AbilityExp { get; } = abilityExp;

  public virtual void TriggerCascadeUpgrade(int exp)
  {
    Exp.IncreasePoints(exp);
    AbilityExp.CascadeUpgrade(exp);
  }

  public NenPrinciple Clone()
  {
    return new NenPrinciple(Exp.Clone(), AbilityExp);
  }
}