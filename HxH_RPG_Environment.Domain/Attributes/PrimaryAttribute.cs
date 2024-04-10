using HxH_RPG_Environment.Domain.Abilities;
using HxH_RPG_Environment.Domain.Experiences;

namespace HxH_RPG_Environment.Domain.Attributes;

public class PrimaryAttribute(
  Experience exp,
  IAbility ability) : IGameAttribute
{
  public int Points { get; private set; }
  public Experience Exp { get; } = exp;
  public IAbility Ability { get; } = ability;

  public void CascadeUpgrade(int exp)
  {
    Exp.IncreasePoints(exp);
    Ability.CascadeUpgrade(exp);
  }

  public double GetHalfOfAbilityLvl()
  {
    return Ability.GetHalfLvl();
  }

  public PrimaryAttribute Clone()
  {
    return new PrimaryAttribute(Exp.Clone(), Ability);
  }
}