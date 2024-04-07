using HxH_RPG_Environment.Domain.Experiences;
using HxH_RPG_Environment.Domain.Status;

namespace HxH_RPG_Environment.Domain.Spirituals;

public class NenStatus : NenPrinciple, IGenerateStatus
{
  public IStatus Status { get; }

  public NenStatus(
    IStatus status,
    Experience exp,
    ICascadeUpgrade abilityExp) : base(exp, abilityExp)
  {
    Status = status;
    Status.StatusUpgrade(exp.GetLvl());
  }

  public override void TriggerCascadeUpgrade(int exp)
  {
    int diff = Exp.IncreasePoints(exp);
    AbilityExp.CascadeUpgrade(exp);

    if (diff != 0) Status.StatusUpgrade(Exp.GetLvl());
  }
}