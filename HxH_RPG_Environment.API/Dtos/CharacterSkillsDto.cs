namespace HxH_RPG_Environment.API.Dtos;

public class CharacterSkillsDto(
  SkillsManagerDto physicalSkills,
  SkillsManagerDto mentalSkills,
  SkillsManagerDto spiritualSkills)
{
  public SkillsManagerDto PhysicalSkills { get; set; } = physicalSkills;
  public SkillsManagerDto MentalSkills { get; set; } = mentalSkills;
  public SkillsManagerDto SpiritualSkills { get; set; } = spiritualSkills;
}