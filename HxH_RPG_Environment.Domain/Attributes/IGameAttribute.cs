using HxH_RPG_Environment.Domain.Abilities;
using HxH_RPG_Environment.Domain.Experiences;

namespace HxH_RPG_Environment.Domain.Attributes;

public interface IGameAttribute : ICascadeUpgrade
{
  public int Points { get; }

  public double GetHalfOfAbilityLvl();

  public int GetPower()
  {
    return Points + Exp.GetLvl() + (int)GetHalfOfAbilityLvl();
  }
}