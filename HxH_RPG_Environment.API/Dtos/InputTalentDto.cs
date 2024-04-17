using System.ComponentModel.DataAnnotations;

namespace HxH_RPG_Environment.API.Dtos;

public class InputTalentDto(InputExperienceDto exp)
{
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