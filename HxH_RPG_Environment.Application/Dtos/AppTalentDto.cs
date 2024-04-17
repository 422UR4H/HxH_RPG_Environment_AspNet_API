namespace HxH_RPG_Environment.Application.Dtos;

public class AppTalentDto(AppExperienceDto exp)
{
  public AppExperienceDto Exp { get; set; } = exp;
}