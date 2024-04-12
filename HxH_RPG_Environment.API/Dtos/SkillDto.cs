using System.ComponentModel.DataAnnotations;
using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.API.Dtos;

public class SkillsDto(SkillName name, ExperienceDto exp)
{
  [Required(ErrorMessage = "Field {0} is mandatory")]
  public SkillName Name { get; set; } = name;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public ExperienceDto Exp { get; set; } = exp;
}