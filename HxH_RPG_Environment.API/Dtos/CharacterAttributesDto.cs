using System.ComponentModel.DataAnnotations;

namespace HxH_RPG_Environment.API.Dtos;

public class CharacterAttributesDto(
  AttributeDto[] physicAttributes,
  AttributeDto[] mentalAttributes,
  AttributeDto[] spiritAttributes)
{
  [Required(ErrorMessage = "Field {0} is mandatory")]
  public AttributeDto[] PhysicAttributes { get; set; } = physicAttributes;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public AttributeDto[] MentalAttributes { get; set; } = mentalAttributes;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public AttributeDto[] SpiritAttributes { get; set; } = spiritAttributes;
}