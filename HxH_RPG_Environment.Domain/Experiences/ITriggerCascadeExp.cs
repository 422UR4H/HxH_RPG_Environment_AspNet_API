namespace HxH_RPG_Environment.Domain.Experiences;

public interface ITriggerCascadeExp
{
  public Experience Exp { get; }
  public void TriggerCascadeUpgrade(int exp);
}