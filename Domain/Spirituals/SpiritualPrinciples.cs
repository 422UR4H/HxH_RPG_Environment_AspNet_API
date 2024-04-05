using HxH_RPG_Environment.Domain.Enums;
using HxH_RPG_Environment.Domain.Experiences;

namespace HxH_RPG_Environment.Domain.Spirituals;

public class SpiritualPrinciples
{
  private const double COEFFICIENT = 1.0;
  public Hatsu Hatsu { get; }
  public readonly Dictionary<NenPrincipleName, NenPrinciple> principles = [];

  public SpiritualPrinciples(ICascadeUpgrade abilityExp/*, Hatsu hatsu*/)
  {
    // Hatsu = hatsu;

    Experience exp = new(new ExpTable(COEFFICIENT));
    NenPrinciple principle = new(exp, abilityExp);

    foreach (NenPrincipleName name in Enum.GetValues(typeof(NenPrincipleName)))
    {
      if (name == NenPrincipleName.Hatsu) continue;
      principles.Add(name, principle.Clone());
    }
    Hatsu = new(exp.Clone(), abilityExp);
  }

  // TODO: refactor this exception
  public IPrinciple Get(NenPrincipleName name)
  {
    if (name == NenPrincipleName.Hatsu) return Hatsu;

    return principles.GetValueOrDefault(name) ??
      throw new Exception("Nen Principle not found!");
  }

  public int GetLvlOf(NenPrincipleName name)
  {
    return Get(name).GetLvl();
  }

  public int GetLvlOf(NenCategoryName name)
  {
    return Hatsu.GetLvlOf(name);
  }
}