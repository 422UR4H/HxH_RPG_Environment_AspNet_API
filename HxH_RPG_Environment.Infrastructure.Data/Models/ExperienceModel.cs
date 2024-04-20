namespace HxH_RPG_Environment.Infrastructure.Data.Models;

public class ExperienceModel(int points = 0) : BaseModel
{
  public ulong Id { get; set; }
  public int Points { get; set; } = points;
}