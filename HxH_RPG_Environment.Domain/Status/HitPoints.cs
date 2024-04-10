namespace HxH_RPG_Environment.Domain.Status;

public class HitPoints : IStatus
{
  public int Min { get; private set; }
  public int Current { get; private set; }
  public int Max { get; private set; }

  public HitPoints(int min = 0)
  {
    Min = min;

    int points = 0;
    Current = points;
    Max = points;
  }

  public void StatusUpgrade(int level)
  {
    // TODO: Implement Min
    // Min = generateStatus.GetLvl();

    // TODO: Implement else case
    if (Current == Max) Current = level;

    Max = level;
  }
}
