namespace HxH_RPG_Environment.API.Dtos;

public class SkillsManagerDto(ExperienceDto exp)
{
  public ExperienceDto Exp { get; set; } = exp;
}