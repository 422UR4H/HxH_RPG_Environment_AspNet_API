using HxH_RPG_Environment.Domain.Enums;
using HxH_RPG_Environment.Domain.Experiences;

namespace HxH_RPG_Environment.Domain.Abilities;

public class AbilitiesManager(
  CharacterExp characterExp,
  Dictionary<AbilityName, Ability> abilities,
  Talent talent)
{
  public CharacterExp CharacterExp { get; } = characterExp;
  public Dictionary<AbilityName, Ability> Abilities { get; } = abilities;
  public Talent Talent { get; } = talent;

  // TODO: refactor this exception
  public Ability Get(AbilityName name)
  {
    return Abilities.GetValueOrDefault(name) ??
      throw new Exception("Ability not found!");
  }

  public int GetExpPointsOf(AbilityName name)
  {
    return Get(name).GetExpPoints();
  }

  public int GetLevelOf(AbilityName name)
  {
    return Get(name).GetLevel();
  }
}