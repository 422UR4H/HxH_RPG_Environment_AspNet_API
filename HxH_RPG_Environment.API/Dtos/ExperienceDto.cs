using System.ComponentModel.DataAnnotations;

namespace HxH_RPG_Environment.API.Dtos;

public class ExperienceDto(int points, int level)
{
  [Required(ErrorMessage = "Field {0} is mandatory")]
  public int Points { get; set; } = points;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public int Level { get; set; } = level;
}