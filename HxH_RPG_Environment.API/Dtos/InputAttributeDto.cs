using System.ComponentModel.DataAnnotations;
using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.API.Dtos;

public class InputAttributeDto(AttributeName name, InputExperienceDto exp, int points)
{
  [Required(ErrorMessage = "Field {0} is mandatory")]
  public AttributeName Name { get; set; } = name;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public InputExperienceDto Exp { get; set; } = exp;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public int Points { get; set; } = points;

  public int GetExpPoints()
  {
    return Exp.Points;
  }

  public int GetLevel()
  {
    return Exp.Level;
  }
}