using HxH_RPG_Environment.Domain.Experiences;

namespace HxH_RPG_Environment.Domain.Spirituals;

public class NenCategory(Experience exp, ICascadeUpgrade hatsuExp) : ITriggerCascadeExp
{
  public Experience Exp { get; } = exp;
  public ICascadeUpgrade HatsuExp { get; } = hatsuExp;

  public void TriggerCascadeUpgrade(int exp)
  {
    Exp.IncreasePoints(exp);
    HatsuExp.CascadeUpgrade(exp);
  }

  public int GetLvl()
  {
    return Exp.GetLvl();
  }

  public int GetExpPoints()
  {
    return Exp.Points;
  }

  public int IncreaseExp(int points)
  {
    return Exp.IncreasePoints(points);
  }

  public NenCategory Clone()
  {
    return new NenCategory(Exp.Clone(), HatsuExp);
  }
}