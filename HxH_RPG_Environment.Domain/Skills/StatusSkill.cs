using HxH_RPG_Environment.Domain.Attributes;
using HxH_RPG_Environment.Domain.Experiences;
using HxH_RPG_Environment.Domain.Status;

namespace HxH_RPG_Environment.Domain.Skills;

public class StatusSkill : PersonSkill, IGenerateStatus
{
  public IStatus Status { get; }

  public StatusSkill(
    IStatus status,
    Experience exp,
    IGameAttribute attribute,
    IEndCascadeUpgrade abilitySkillsExp)
    : base(exp, attribute, abilitySkillsExp)
  {
    Status = status;
    Status.StatusUpgrade(GetLvl());
  }

  public override void TriggerCascadeUpgrade(int exp)
  {
    int diff = Exp.IncreasePoints(exp);
    Attribute.CascadeUpgrade(exp);
    AbilitySkillsExp.TriggerEndUpgrade(exp);

    if (diff != 0) Status.StatusUpgrade(Exp.GetLvl());
  }
}