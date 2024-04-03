using HxH_RPG_Environment.Domain.Experiences;

namespace HxH_RPG_Environment.Domain.Skills;

public interface ISkill : ICascadeUpgrade
{
  public ICascadeUpgrade AttributeExp { get; }

  public new void Upgrade(int exp)
  {
    Exp.IncreasePoints(exp);
    AttributeExp.Upgrade(exp);
  }

  public int GetExp()
  {
    return Exp.Points;
  }

  public int GetLvl()
  {
    return Exp.GetLvl();
  }
}