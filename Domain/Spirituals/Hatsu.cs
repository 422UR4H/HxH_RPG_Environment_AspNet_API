using HxH_RPG_Environment.Domain.Enums;
using HxH_RPG_Environment.Domain.Experiences;

namespace HxH_RPG_Environment.Domain.Spirituals;

// TODO: add ISpecialSkill spiritualSpecialSkill
public class Hatsu : IPrinciple, ICascadeUpgrade
{
  // TODO: calculate this coefficient
  private const double COEFFICIENT = 1.0;
  public Experience Exp { get; }
  public ICascadeUpgrade AbilityExp { get; }
  public readonly Dictionary<NenCategoryName, NenCategory> categories = [];

  public Hatsu(Experience exp, ICascadeUpgrade abilityExp)
  {
    Exp = exp;
    AbilityExp = abilityExp;

    Experience skillExp = new(new ExpTable(COEFFICIENT));
    NenCategory category = new(skillExp, this);

    foreach (NenCategoryName name in Enum.GetValues(typeof(NenCategoryName)))
    {
      categories.Add(name, category.Clone());
    }
  }

  // TODO: refactor this exception
  public NenCategory Get(NenCategoryName name)
  {
    return categories.GetValueOrDefault(name) ??
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