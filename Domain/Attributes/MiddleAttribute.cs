using HxH_RPG_Environment.Domain.Experiences;

namespace HxH_RPG_Environment.Domain.Attributes;

public class MiddleAttribute(
  Experience exp,
  ICollection<ICascadeUpgrade> primaryAttrExp) : IGameAttribute
{
  public int Points { get; private set; }
  public Experience Exp { get; } = exp;
  public ICollection<ICascadeUpgrade> PrimaryAttrExps { get; } = primaryAttrExp;

  public void CascadeUpgrade(int exp)
  {
    Exp.IncreasePoints(exp);
    foreach (ICascadeUpgrade primaryAttrExp in PrimaryAttrExps)
    {
      primaryAttrExp.CascadeUpgrade(exp);
    }
  }
}