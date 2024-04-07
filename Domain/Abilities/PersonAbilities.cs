using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.Domain.Abilities;

public class PersonAbilities(
  Dictionary<AbilityName, Ability> abilities,
  Talent talent)
{
  private readonly Dictionary<AbilityName, Ability> _abilities = abilities;
  public Talent Talent { get; } = talent;

  // TODO: refactor this exception
  public Ability Get(AbilityName name)
  {
    return _abilities.GetValueOrDefault(name) ??
      throw new Exception("Ability not found!");
  }
}