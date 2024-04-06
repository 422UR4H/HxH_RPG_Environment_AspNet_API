namespace HxH_RPG_Environment.Domain.Experiences;

public class Experience
{
  private readonly ExpTable ExpTable;
  public int Points { get; private set; }
  private int level;

  public Experience(ExpTable expTable, int points = 0)
  {
    ExpTable = expTable;
    Points = points;
    level = ExpTable.GetLvlByExp(Points);
  }

  public int GetLvl()
  {
    return level;
  }

  public int GetBaseExpByLvl(int lvl)
  {
    return ExpTable.GetBaseExpByLvl(lvl);
  }

  public int GetAggregateExpByLvl(int lvl)
  {
    return ExpTable.GetAggregateExpByLvl(lvl);
  }

  public int GetCurrentExp()
  {
    return Points - ExpTable.GetAggregateExpByLvl(level);
  }

  public int GetExpToEvolve()
  {
    return GetAggregateExpByLvl(level + 1) - GetCurrentExp();
  }

  private int GetLvlByExp()
  {
    return ExpTable.GetLvlByExp(Points);
  }

  public void Upgrade()
  {
    level = GetLvlByExp();
  }

  // returns level diff
  public int IncreasePoints(int exp)
  {
    Points += exp;

    int diff = GetLvlByExp() - level;
    if (diff != 0) Upgrade();
    return diff;
  }

  public Experience Clone()
  {
    return new Experience(ExpTable, Points);
  }
}