using HxH_RPG_Environment.Domain.Enums;
using HxH_RPG_Environment.Domain.Experiences;

namespace HxH_RPG_Environment.Domain.Abilities;

public class PersonAbilities
{
  private const double PHYSICAL_COEFFICIENT = 20.0;
  private const double MENTAL_COEFFICIENT = 15.0;
  private const double SPIRITUAL_COEFFICIENT = 5.0;
  private const double SKILLS_COEFFICIENT = 5.0;
  private readonly Dictionary<AbilityName, Ability> abilities = [];
  IEndCascadeUpgrade CharacterExp { get; }

  public PersonAbilities(IEndCascadeUpgrade characterExp)
  {
    CharacterExp = characterExp;

    Experience physicalExp = new(new ExpTable(PHYSICAL_COEFFICIENT));
    abilities.Add(AbilityName.PHYSICALS, new(physicalExp, CharacterExp));

    Experience mentalExp = new(new ExpTable(MENTAL_COEFFICIENT));
    abilities.Add(AbilityName.MENTALS, new(mentalExp, CharacterExp));

    Experience spiritualExp = new(new ExpTable(SPIRITUAL_COEFFICIENT));
    abilities.Add(AbilityName.SPIRITUALS, new(spiritualExp, CharacterExp));

    Experience skillsExp = new(new ExpTable(SKILLS_COEFFICIENT));
    abilities.Add(AbilityName.SKILLS, new(skillsExp, CharacterExp));

    // knowlegde exp

    // talent
  }

  // TODO: refactor to throw exception
  public Ability? Get(AbilityName name)
  {
    abilities.TryGetValue(name, out Ability? ability);
    return ability;
  }
}