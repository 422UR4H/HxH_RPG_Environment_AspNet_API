namespace HxH_RPG_Environment.API.Dtos;

public class AbilitiesDto(
  AbilityDto physicAbility,
  AbilityDto mentalAbility,
  AbilityDto spiritAbility,
  TalentDto talent)
{
  public AbilityDto PhysicAbility { get; set; } = physicAbility;
  public AbilityDto MentalAbility { get; set; } = mentalAbility;
  public AbilityDto SpiritAbility { get; set; } = spiritAbility;
  public TalentDto Talent { get; set; } = talent;
}