using System.ComponentModel.DataAnnotations;

namespace HxH_RPG_Environment.API.Dtos;

public class InputCharacterAttributesDto(
  InputAttributesManagerDto physicAttributes,
  InputAttributesManagerDto mentalAttributes,
  InputAttributesManagerDto spiritAttributes)
{
  [Required(ErrorMessage = "Field {0} is mandatory")]
  public InputAttributesManagerDto PhysicAttributes { get; set; } = physicAttributes;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public InputAttributesManagerDto MentalAttributes { get; set; } = mentalAttributes;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public InputAttributesManagerDto SpiritAttributes { get; set; } = spiritAttributes;
}