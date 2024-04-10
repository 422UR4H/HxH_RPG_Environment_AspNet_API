using HxH_RPG_Environment.Domain.Experiences;

namespace HxH_RPG_Environment.Domain.Abilities;

public interface IAbility : ICascadeUpgrade
{
  public IEndCascadeUpgrade CharacterExp { get; }

  public double GetHalfLvl()
  {
    return Exp.GetLvl() / 2;
  }
}