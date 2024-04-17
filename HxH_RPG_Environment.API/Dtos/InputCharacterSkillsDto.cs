using System.ComponentModel.DataAnnotations;

namespace HxH_RPG_Environment.API.Dtos;

public class InputCharacterSkillsDto(
  InputSkillsManagerDto physicalSkills,
  InputSkillsManagerDto mentalSkills,
  InputSkillsManagerDto spiritualSkills)
{
  [Required(ErrorMessage = "Field {0} is mandatory")]
  public InputSkillsManagerDto PhysicalSkills { get; set; } = physicalSkills;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public InputSkillsManagerDto MentalSkills { get; set; } = mentalSkills;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public InputSkillsManagerDto SpiritualSkills { get; set; } = spiritualSkills;
}