using HxH_RPG_Environment.Domain.Experiences;

namespace HxH_RPG_Environment.Domain.Status;

public interface IGenerateStatus : ITriggerCascadeExp
{
  public IStatus Status { get; }
}