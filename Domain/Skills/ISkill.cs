using HxH_RPG_Environment.Domain.Attributes;
using HxH_RPG_Environment.Domain.Experiences;

namespace HxH_RPG_Environment.Domain.Skills;

public interface ISkill : ITriggerCascadeExp
{
  public IGameAttribute Attribute { get; }
  public IEndCascadeUpgrade AbilitySkillsExp { get; }

  public int GetLvl();
  public int GetValueForTest();
}