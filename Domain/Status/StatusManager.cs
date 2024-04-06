using HxH_RPG_Environment.Domain.Enums;
using HxH_RPG_Environment.Domain.Skills;

namespace HxH_RPG_Environment.Domain.Status;

public class StatusManager
{
  private IGenerateStatus Vitality { get; }
  private IGenerateStatus Resistance { get; }
  private IGenerateStatus Mop { get; }
  private readonly Dictionary<StatusName, IStatus> status = [];

  public StatusManager(
    IGenerateStatus vitality,
    IGenerateStatus resistance,
    IGenerateStatus mop)
  {
    Vitality = vitality;
    Resistance = resistance;
    Mop = mop;

    HitPoints health = new(Vitality);
    status.Add(StatusName.Health, health);

    StaminaPoints stamina = new(Resistance);
    status.Add(StatusName.Stamina, stamina);

    AuraPoints aura = new(Mop);
    status.Add(StatusName.Aura, aura);
  }
}