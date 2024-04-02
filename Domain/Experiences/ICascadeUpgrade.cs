using HxH_RPG_Environment.Domain.Experiences;

namespace HxH_RPG_Environment.Domain.PubSub;

public interface ICascadeUpgrade
{
  public Experience Exp { get; }
  public void Upgrade(int exp);
}