using HxH_RPG_Environment.Domain.Experiences;

namespace HxH_RPG_Environment.Domain.Skills;

public interface ISkill : IIncreaseCascadeExp
{
  public ICascadeUpgrade AttributeExp { get; }
  public Experience AbilitySkillsExp { get; }
}