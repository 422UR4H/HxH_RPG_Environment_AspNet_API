using HxH_RPG_Environment.Domain.Experiences;

namespace HxH_RPG_Environment.Domain.Attributes;

public class MiddleAttribute(
  Experience exp,
  ICollection<PrimaryAttribute> primaryAttributes) : IGameAttribute
{
  public int Points
  {
    get
    {
      int points = 0;
      foreach (PrimaryAttribute primaryAttribute in PrimaryAttributes)
      {
        points += primaryAttribute.Points;
      }
      return (int)Math.Round((double)points / (double)PrimaryAttributes.Count);
    }
  }
  public Experience Exp { get; } = exp;
  public ICollection<PrimaryAttribute> PrimaryAttributes { get; } = primaryAttributes;

  public void CascadeUpgrade(int exp)
  {
    Exp.IncreasePoints(exp);
    foreach (PrimaryAttribute primaryAttribute in PrimaryAttributes)
    {
      primaryAttribute.CascadeUpgrade(exp);
    }
  }

  public double GetHalfOfAbilityLvl()
  {
    if (PrimaryAttributes.Count == 0) return 0;

    double value = 0;
    foreach (PrimaryAttribute primaryAttribute in PrimaryAttributes)
    {
      value += primaryAttribute.GetHalfOfAbilityLvl();
    }
    return value / PrimaryAttributes.Count;
  }
}