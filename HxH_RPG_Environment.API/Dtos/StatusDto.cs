using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.API.Dtos;

public class StatusDto(StatusName name, int min, int current, int max)
{
  public StatusName Name { get; set; } = name;
  public int Min { get; set; } = min;
  public int Current { get; set; } = current;
  public int Max { get; set; } = max;
}