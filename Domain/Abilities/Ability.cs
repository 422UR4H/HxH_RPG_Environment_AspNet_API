using HxH_RPG_Environment.Domain.Experiences;

namespace HxH_RPG_Environment.Domain.Abilities;

public class Ability(Experience exp, IEndCascadeUpgrade characterExp) : IAbility
{
  public Experience Exp { get; } = exp;
  public IEndCascadeUpgrade CharacterExp { get; } = characterExp;

  public void CascadeUpgrade(int exp)
  {
    Exp.IncreasePoints(exp);
    CharacterExp.TriggerEndUpgrade(exp);
  }
}