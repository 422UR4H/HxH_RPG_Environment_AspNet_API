namespace HxH_RPG_Environment.Domain.Experiences;

public interface IIncreaseCascadeExp
{
  public Experience Exp { get; }
  public void IncreaseCascadeExp(int exp);
}