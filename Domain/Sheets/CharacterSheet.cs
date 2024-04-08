using HxH_RPG_Environment.Domain.Abilities;
using HxH_RPG_Environment.Domain.Status;

namespace HxH_RPG_Environment.Domain.Sheets;

public class CharacterSheet(
  Profile profile,
  AbilitiesManager abilities,
  StatusManager status
  // CharacterClass characterClass
  )
{
  public Profile Profile { get; } = profile;
  public AbilitiesManager Abilities { get; } = abilities;
  public StatusManager Status { get; } = status;
}