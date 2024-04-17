namespace HxH_RPG_Environment.Application.Dtos;

public class AppExperienceDto(int points, int level)
{
  public int Points { get; set; } = points;
  public int Level { get; set; } = level;
}