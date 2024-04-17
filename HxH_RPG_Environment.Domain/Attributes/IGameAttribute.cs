using HxH_RPG_Environment.Domain.Experiences;

namespace HxH_RPG_Environment.Domain.Attributes;

public interface IGameAttribute : ICascadeUpgrade
{
  public int Points { get; }

  public double GetHalfOfAbilityLvl();

  public int GetExpPoints()
  {
    return Exp.Points;
  }

  public int GetLevel()
  {
    return Exp.GetLvl();
  }

  public int GetPower()
  {
    return Points + GetLevel() + (int)GetHalfOfAbilityLvl();
  }
}