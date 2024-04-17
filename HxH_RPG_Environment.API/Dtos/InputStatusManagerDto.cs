using System.ComponentModel.DataAnnotations;

namespace HxH_RPG_Environment.API.Dtos;

public class InputStatusManagerDto(InputStatusDto[] status)
{
  [Required(ErrorMessage = "Field {0} is mandatory")]
  public InputStatusDto[] Status { get; set; } = status;
}