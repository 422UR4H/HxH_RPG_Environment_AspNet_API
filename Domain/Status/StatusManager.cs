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
}