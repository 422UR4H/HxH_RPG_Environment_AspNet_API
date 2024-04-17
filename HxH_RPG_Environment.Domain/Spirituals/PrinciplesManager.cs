using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.Domain.Spirituals;

public class PrinciplesManager(
  Dictionary<NenPrincipleName, NenPrinciple> principles,
  Hatsu hatsu)
{
  public Dictionary<NenPrincipleName, NenPrinciple> Principles { get; } = principles;
  public Hatsu Hatsu { get; } = hatsu;

  // TODO: refactor this exception
  public IPrinciple Get(NenPrincipleName name)
  {
    if (name == NenPrincipleName.Hatsu) return Hatsu;

    return Principles.GetValueOrDefault(name) ??
      throw new Exception("Nen Principle not found!");
  }

  public int GetExpPointsOf(NenPrincipleName name)
  {
    return Get(name).GetExpPoints();
  }

  public int GetExpPointsOf(NenCategoryName name)
  {
    return Hatsu.GetExpPoints(name);
  }

  public int GetLevelOf(NenPrincipleName name)
  {
    return Get(name).GetLvl();
  }

  public int GetLevelOf(NenCategoryName name)
  {
    return Hatsu.GetLvlOf(name);
  }

  public int IncreaseExp(int exp, NenPrincipleName name)
  {
    return Get(name).IncreaseExp(exp);
  }

  public int IncreaseExp(int exp, NenCategoryName name)
  {
    return Hatsu.IncreaseExp(exp, name);
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