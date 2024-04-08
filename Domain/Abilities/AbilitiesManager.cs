using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.Domain.Abilities;

public class AbilitiesManager(
  Dictionary<AbilityName, Ability> abilities,
  Talent talent)
{
  public Dictionary<AbilityName, Ability> Abilities { get; } = abilities;
  public Talent Talent { get; } = talent;

  // TODO: refactor this exception
  public Ability Get(AbilityName name)
  {
    return Abilities.GetValueOrDefault(name) ??
      throw new Exception("Ability not found!");
  }
}