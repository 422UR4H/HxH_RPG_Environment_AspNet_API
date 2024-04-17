using System.ComponentModel.DataAnnotations;

namespace HxH_RPG_Environment.API.Dtos;

public class InputAttributesManagerDto(
  InputAttributeDto[] attributes)
{
  [Required(ErrorMessage = "Field {0} is mandatory")]
  public InputAttributeDto[] Attributes { get; set; } = attributes;
}