namespace HxH_RPG_Environment.Domain.Status;

public class StaminaPoints : IStatus
{
  public int Min { get; private set; }
  public int Current { get; private set; }
  public int Max { get; private set; }

  public StaminaPoints()
  {
    Min = 0;

    int points = 0;
    Current = points;
    Max = points;
  }

  public void StatusUpgrade(int level)
  {
    // TODO: Implement else case
    if (Current == Max) Current = level;

    Max = level;
  }
}
