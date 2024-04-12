namespace HxH_RPG_Environment.API.Dtos;

public class TalentDto(ExperienceDto exp)
{
  public ExperienceDto Exp { get; set; } = exp;
}