namespace HxH_RPG_Environment.API.Dtos;

public class AbilityDto(ExperienceDto exp)
{
  public ExperienceDto Exp { get; set; } = exp;
}