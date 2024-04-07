using HxH_RPG_Environment.Domain.Enums;
using HxH_RPG_Environment.Domain.Experiences;

namespace HxH_RPG_Environment.Domain.Spirituals;

// TODO: add ISpecialSkill spiritualSpecialSkill
public class Hatsu(
  Experience exp,
  ICascadeUpgrade abilityExp) : IPrinciple, ICascadeUpgrade
{
  public Experience Exp { get; } = exp;
  public ICascadeUpgrade AbilityExp { get; } = abilityExp;
  public Dictionary<NenCategoryName, NenCategory> Categories { get; private set; } = [];

  public void Init(Dictionary<NenCategoryName, NenCategory> categories)
  {
    if (categories.Count > 0)
    {
      Console.WriteLine("Hatsu already initialized with categories!");
      return;
    }
    Categories = categories;
  }

  // TODO: refactor this exception
  public NenCategory Get(NenCategoryName name)
  {
    return Categories.GetValueOrDefault(name) ??
      throw new Exception("Nen Category not found!");
  }

  public int GetLvlOf(NenCategoryName name)
  {
    return Get(name).GetLvl();
  }

  public void CascadeUpgrade(int exp)
  {
    Exp.IncreasePoints(exp);
    AbilityExp.CascadeUpgrade(exp);
  }
}