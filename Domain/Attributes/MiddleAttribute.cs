using HxH_RPG_Environment.Domain.Experiences;

namespace HxH_RPG_Environment.Domain.Attributes;

public class MiddleAttribute(
  Experience exp,
  ICollection<PrimaryAttribute> primaryAttributes) : IGameAttribute
{
  public int Points { get; private set; }
  public Experience Exp { get; } = exp;
  public ICollection<PrimaryAttribute> PrimaryAttributes { get; } = primaryAttributes;

  public void CascadeUpgrade(int exp)
  {
    Exp.IncreasePoints(exp);
    foreach (PrimaryAttribute primaryAttributes in PrimaryAttributes)
    {
      primaryAttributes.CascadeUpgrade(exp);
    }
  }

  public double GetHalfOfAbilityLvl()
  {
    if (PrimaryAttributes.Count == 0) return 0;

    double value = 0;
    foreach (PrimaryAttribute primaryAttributes in PrimaryAttributes)
    {
      value += primaryAttributes.GetHalfOfAbilityLvl();
    }
    return value / PrimaryAttributes.Count;
  }
}