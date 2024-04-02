using HxH_RPG_Environment.Domain.Experiences;

namespace HxH_RPG_Environment.Domain.Attributes;

public abstract class MiddleAttribute(
  Experience exp,
  ICascadeUpgrade abilityExp,
  ICollection<ICascadeUpgrade> primaryAttrExp)
  : IGameAttribute, ICascadeUpgrade
{
  public int Points { get; private set; }
  public Experience Exp { get; } = exp;
  public ICascadeUpgrade AbilityExp { get; } = abilityExp;
  public ICollection<ICascadeUpgrade> PrimaryAttrExps { get; } = primaryAttrExp;

  public void Upgrade(int value)
  {
    Exp.IncreasePoints(value);
    foreach (ICascadeUpgrade primaryAttrExp in PrimaryAttrExps)
    {
      primaryAttrExp.Upgrade(value);
    }
  }
}