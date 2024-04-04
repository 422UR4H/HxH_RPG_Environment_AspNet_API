namespace HxH_RPG_Environment.Domain.Experiences;

public interface ICascadeUpgrade
{
  public Experience Exp { get; }
  public void CascadeUpgrade(int exp);
}