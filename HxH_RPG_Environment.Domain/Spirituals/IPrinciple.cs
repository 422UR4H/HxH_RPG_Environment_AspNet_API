using HxH_RPG_Environment.Domain.Experiences;

namespace HxH_RPG_Environment.Domain.Spirituals;

public interface IPrinciple
{
  public Experience Exp { get; }
  public ICascadeUpgrade AbilityExp { get; }

  public int GetLvl()
  {
    return Exp.GetLvl();
  }
}