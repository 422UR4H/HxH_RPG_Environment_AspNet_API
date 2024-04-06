namespace HxH_RPG_Environment.Domain.Status;

public class AuraPoints : IStatus
{
  public IGenerateStatus GenerateStatus { get; private init; }
  public int Min { get; private set; }
  public int Current { get; private set; }
  public int Max { get; private set; }

  public AuraPoints(IGenerateStatus skill)
  {
    GenerateStatus = skill;
    Min = 0;

    int points = GenerateStatus.GetLvl();
    Current = points;
    Max = points;
  }

  public void UpgradeStatus()
  {
    // TODO: Implement else case
    if (Current == Max) Current = GenerateStatus.GetLvl();

    Max = GenerateStatus.GetLvl();
  }
}
