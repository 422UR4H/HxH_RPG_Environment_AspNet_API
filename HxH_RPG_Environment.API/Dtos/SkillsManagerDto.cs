using System.ComponentModel.DataAnnotations;

namespace HxH_RPG_Environment.API.Dtos;

public class SkillsManagerDto(ExperienceDto exp)
{
  [Required(ErrorMessage = "Field {0} is mandatory")]
  public ExperienceDto Exp { get; set; } = exp;
}