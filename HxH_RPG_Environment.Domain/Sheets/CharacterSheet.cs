using HxH_RPG_Environment.Domain.Abilities;
using HxH_RPG_Environment.Domain.Attributes;
using HxH_RPG_Environment.Domain.Enums;
using HxH_RPG_Environment.Domain.Skills;
using HxH_RPG_Environment.Domain.Spirituals;
using HxH_RPG_Environment.Domain.Status;

namespace HxH_RPG_Environment.Domain.Sheets;

public class CharacterSheet(
  Profile profile,
  AbilitiesManager abilities,
  CharacterAttributes attributes,
  PrinciplesManager principles,
  CharacterSkills skills,
  StatusManager status
  // CharacterClass characterClass
  )
{
  public Profile Profile { get; } = profile;
  public AbilitiesManager Abilities { get; } = abilities;
  public CharacterAttributes Attributes { get; } = attributes;
  public CharacterSkills Skills { get; } = skills;
  public PrinciplesManager Principles { get; } = principles;
  public StatusManager Status { get; } = status;

  public int GetValueForTestOf(SkillName name)
  {
    return Skills.GetValueForTestOf(name);
  }

  public int GetValueForTestOf(AttributeName name)
  {
    return Attributes.GetPowerOf(name);
  }

  public int IncreaseExp(int points, SkillName name)
  {
    return Skills.IncreaseExp(points, name);
  }

  public int IncreaseExp(int points, NenPrincipleName name)
  {
    return Principles.IncreaseExp(points, name);
  }

  public int IncreaseExp(int points, NenCategoryName name)
  {
    return Principles.IncreaseExp(points, name);
  }

  public int GetMaxOf(StatusName name)
  {
    return Status.GetMaxOf(name);
  }

  public int GetMinOf(StatusName name)
  {
    return Status.GetMinOf(name);
  }

  public int GetLevelOf(AbilityName name)
  {
    return Abilities.GetLevelOf(name);
  }

  public int GetLevelOf(AttributeName name)
  {
    return Attributes.GetLevelOf(name);
  }

  public int GetLevelOf(SkillName name)
  {
    return Skills.GetLevelOf(name);
  }

  public int GetLevelOf(NenPrincipleName name)
  {
    return Principles.GetLevelOf(name);
  }

  public int GetLevelOf(NenCategoryName name)
  {
    return Principles.GetLevelOf(name);
  }

  public int GetExpPointsOf(AbilityName name)
  {
    return Abilities.GetExpPointsOf(name);
  }

  public int GetExpPointsOf(AttributeName name)
  {
    return Attributes.GetExpPointsOf(name);
  }

  public int GetExpPointsOf(SkillName name)
  {
    return Skills.GetExpPointsOf(name);
  }

  public int GetExpPointsOf(NenPrincipleName name)
  {
    return Principles.GetExpPointsOf(name);
  }

  public int GetExpPointsOf(NenCategoryName name)
  {
    return Principles.GetExpPointsOf(name);
  }
}