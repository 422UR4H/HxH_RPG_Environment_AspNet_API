using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.Domain.Status;

public class StatusManager(Dictionary<StatusName, IStatus> status)
{
  public Dictionary<StatusName, IStatus> Status { get; } = status;

  // TODO: refactor this exception
  public IStatus Get(StatusName name)
  {
    return Status.GetValueOrDefault(name)
      ?? throw new Exception("Status not found!");
  }

  public int GetMaxOf(StatusName name)
  {
    return Get(name).Max;
  }

  public int GetMinOf(StatusName name)
  {
    return Get(name).Min;
  }
}