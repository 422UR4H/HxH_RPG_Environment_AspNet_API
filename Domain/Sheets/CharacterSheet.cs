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
}