using System.ComponentModel.DataAnnotations;
using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.API.Dtos;

public class InputStatusDto(StatusName name, int min, int current, int max)
{
  [Required(ErrorMessage = "Field {0} is mandatory")]
  public StatusName Name { get; set; } = name;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public int Min { get; set; } = min;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public int Current { get; set; } = current;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public int Max { get; set; } = max;
}