using System.ComponentModel.DataAnnotations;

namespace HxH_RPG_Environment.API.Dtos;

public class StatusManagerDto(StatusDto[] status)
{
  [Required(ErrorMessage = "Field {0} is mandatory")]
  public StatusDto[] Status { get; set; } = status;
}