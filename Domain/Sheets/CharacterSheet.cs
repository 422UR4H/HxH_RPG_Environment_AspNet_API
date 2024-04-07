using HxH_RPG_Environment.Domain.Abilities;
using HxH_RPG_Environment.Domain.Status;

namespace HxH_RPG_Environment.Domain.Sheets;

public class CharacterSheet(
  Profile profile,
  PersonAbilities abilities,
  StatusManager status
  // CharacterClass characterClass,
  // PhysicalAttributes physAttributes,
  // MentalAttributes mentalAttributes,
  // SpiritualPrinciples spiritualPrinciples
  )
{
  public Profile Profile { get; } = profile;
  public PersonAbilities Abilities { get; } = abilities;
  public StatusManager Status { get; } = status;
}