using System.ComponentModel.DataAnnotations;
using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.API.Dtos;

public class InputSkillDto(SkillName name, InputExperienceDto exp)
{
  [Required(ErrorMessage = "Field {0} is mandatory")]
  public SkillName Name { get; set; } = name;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public InputExperienceDto Exp { get; set; } = exp;

  public int GetExpPoints()
  {
    return Exp.Points;
  }

  public int GetLevel()
  {
    return Exp.Level;
  }
}