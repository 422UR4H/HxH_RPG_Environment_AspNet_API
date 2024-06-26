namespace HxH_RPG_Environment.Domain.Experiences;

public class ExpTable
{
  public const int MAX_LVL = 100;
  public const double A_PARAM = 3.7;
  public const double B_PARAM = 2.8;

  public double Coefficient { get; }

  private List<int> BaseTable { get; } = [];
  private List<int> AggregateTable { get; } = [];

  public ExpTable(double coefficient = 1.0)
  {
    Coefficient = coefficient;

    BaseTable.Add(0);
    AggregateTable.Add(0);

    for (int i = 1; i <= MAX_LVL; i++)
    {
      int currExp = (int)(coefficient * (
          (1700.0 / (1.0 + Math.Pow(Math.E, A_PARAM / 10.0 * (12.0 - i)))) +
          (1800.0 / (1.0 + Math.Pow(Math.E, A_PARAM / 10.0 * (38.0 - i)))) +
          (2000.0 / (1.0 + Math.Pow(Math.E, B_PARAM / 10.0 * (74.0 - i))))));

      BaseTable.Add(currExp);
      AggregateTable.Add(AggregateTable[i - 1] + currExp);
    }
  }

  public int GetBaseExpByLvl(int lvl)
  {
    return BaseTable[lvl];
  }

  public int GetAggregateExpByLvl(int lvl)
  {
    return AggregateTable[lvl];
  }

  public int GetLvlByExp(int exp)
  {
    return AggregateTable.LastIndexOf(AggregateTable.Last(x => x <= exp));
  }

  public override string ToString()
  {
    string expTable = "=============================\n";
    expTable += "Coef: " + Coefficient + "\n";
    expTable += "Lvl\t| Base\t| Total\n";
    for (int i = 0; i <= MAX_LVL; i++)
    {
      expTable += " " + i + "\t| " + BaseTable[i] + "\t| " + AggregateTable[i] + "\n";
    }
    expTable += "=============================\n";
    return expTable;
  }
}