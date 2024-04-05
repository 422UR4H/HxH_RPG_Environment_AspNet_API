namespace HxH_RPG_Environment.Domain.Experiences;

public interface IEndCascadeUpgrade
{
  public Experience Exp { get; }
  public void TriggerEndUpgrade(int exp);
}