using System.ComponentModel.DataAnnotations;

namespace HxH_RPG_Environment.API.Dtos;

public class AbilitiesDto(
  AbilityDto physicAbility,
  AbilityDto mentalAbility,
  AbilityDto spiritAbility,
  TalentDto talent)
{
  [Required(ErrorMessage = "Field {0} is mandatory")]
  public AbilityDto PhysicAbility { get; set; } = physicAbility;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public AbilityDto MentalAbility { get; set; } = mentalAbility;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public AbilityDto SpiritAbility { get; set; } = spiritAbility;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public TalentDto Talent { get; set; } = talent;
}