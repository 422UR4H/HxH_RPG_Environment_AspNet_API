using HxH_RPG_Environment.Domain.Experiences;

namespace HxH_RPG_Environment.Domain.Skills;

public interface ISkill : ITriggerCascadeExp
{
  public ICascadeUpgrade AttributeExp { get; }
  public IEndCascadeUpgrade AbilitySkillsExp { get; }
}