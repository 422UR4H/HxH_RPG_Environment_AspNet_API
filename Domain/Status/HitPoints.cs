namespace HxH_RPG_Environment.Domain.Status;

public class HitPoints : IStatus
{
  public IGenerateStatus GenerateStatus { get; private init; }
  public int Min { get; private set; }
  public int Current { get; private set; }
  public int Max { get; private set; }

  public HitPoints(IGenerateStatus generateStatus, int min = 0)
  {
    GenerateStatus = generateStatus;
    Min = min;

    int points = GenerateStatus.GetLvl();
    Current = points;
    Max = points;
  }

  public void UpgradeStatus()
  {
    // TODO: Implement Min
    // Min = generateStatus.GetLvl();

    // TODO: Implement else case
    if (Current == Max) Current = GenerateStatus.GetLvl();

    Max = GenerateStatus.GetLvl();
  }
}
