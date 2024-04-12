using System.ComponentModel.DataAnnotations;

namespace HxH_RPG_Environment.API.Dtos;

public class CharacterSkillsDto(
  SkillsManagerDto physicalSkills,
  SkillsManagerDto mentalSkills,
  SkillsManagerDto spiritualSkills)
{
  [Required(ErrorMessage = "Field {0} is mandatory")]
  public SkillsManagerDto PhysicalSkills { get; set; } = physicalSkills;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public SkillsManagerDto MentalSkills { get; set; } = mentalSkills;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public SkillsManagerDto SpiritualSkills { get; set; } = spiritualSkills;
}