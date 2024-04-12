namespace HxH_RPG_Environment.API.Dtos;

public class ExperienceDto(int points, int level)
{
  public int Points { get; set; } = points;
  public int Level { get; set; } = level;
}