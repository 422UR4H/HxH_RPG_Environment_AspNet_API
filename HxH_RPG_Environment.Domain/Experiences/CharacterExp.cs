namespace HxH_RPG_Environment.Domain.Experiences;

public class CharacterExp(Experience exp) : IEndCascadeUpgrade
{
  public Experience Exp { get; } = exp;

  public void TriggerEndUpgrade(int exp)
  {
    Exp.IncreasePoints(exp);
  }
}