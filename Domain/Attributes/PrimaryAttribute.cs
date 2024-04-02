using HxH_RPG_Environment.Domain.Experiences;

namespace HxH_RPG_Environment.Domain.Attributes;

public abstract class PrimaryAttribute(Experience exp, ICascadeUpgrade abilityExp)
  : IGameAttribute, ICascadeUpgrade
{
  public int Points { get; private set; }
  public Experience Exp { get; } = exp;
  public ICascadeUpgrade AbilityExp { get; } = abilityExp;

  public void Upgrade(int value)
  {
    Exp.IncreasePoints(value);
    AbilityExp.Upgrade(value);
  }
}