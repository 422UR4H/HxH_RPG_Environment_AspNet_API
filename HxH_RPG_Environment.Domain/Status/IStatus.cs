namespace HxH_RPG_Environment.Domain.Status;

public interface IStatus
{
  public int Min { get; }
  public int Current { get; }
  public int Max { get; }

  public int Increase(int value)
  {
    int temp = Current + value;

    if (temp > Max) return Max;
    return temp;
  }

  public int Decrease(int value)
  {
    int temp = Current - value;

    // TODO: throw Event
    if (temp < Min) return Min;
    return temp;
  }

  public void StatusUpgrade(int level);
}