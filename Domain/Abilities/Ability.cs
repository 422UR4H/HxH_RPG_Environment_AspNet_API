using HxH_RPG_Environment.Domain.Experiences;

namespace HxH_RPG_Environment.Domain.Abilities;

public class Ability(Experience exp) : ICascadeUpgrade
{
  public Experience Exp { get; } = exp;

  public void Upgrade(int exp)
  {
    Exp.IncreasePoints(exp);
  }
}