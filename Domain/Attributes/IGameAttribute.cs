using HxH_RPG_Environment.Domain.Experiences;

namespace HxH_RPG_Environment.Domain.Attributes;

public interface IGameAttribute : ICascadeUpgrade
{
  public int Points { get; }
  public ICascadeUpgrade AbilityExp { get; }

  public int GetExp()
  {
    return Exp.Points;
  }

  public int GetLvl()
  {
    return Exp.GetLvl();
  }

  public int GetPower()
  {
    return Points + GetLvl();
  }
}