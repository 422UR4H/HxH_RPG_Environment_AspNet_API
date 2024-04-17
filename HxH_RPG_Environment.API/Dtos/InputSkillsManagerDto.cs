using System.ComponentModel.DataAnnotations;

namespace HxH_RPG_Environment.API.Dtos;

public class InputSkillsManagerDto(
  InputExperienceDto exp,
  InputSkillDto[] skills)
{
  [Required(ErrorMessage = "Field {0} is mandatory")]
  public InputExperienceDto Exp { get; set; } = exp;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public InputSkillDto[] Skills { get; set; } = skills;
}