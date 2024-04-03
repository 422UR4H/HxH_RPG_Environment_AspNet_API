using HxH_RPG_Environment.Domain.Experiences;

namespace HxH_RPG_Environment.Domain.Attributes;

public class PrimaryAttribute(
  Experience exp,
  ICascadeUpgrade abilityExp) : IGameAttribute
{
  public int Points { get; private set; }
  public Experience Exp { get; } = exp;
  public ICascadeUpgrade AbilityExp { get; } = abilityExp;

  public void Upgrade(int exp)
  {
    Exp.IncreasePoints(exp);
    AbilityExp.Upgrade(exp);
  }

  public PrimaryAttribute Clone()
  {
    return new PrimaryAttribute(Exp.Clone(), AbilityExp);
  }
}