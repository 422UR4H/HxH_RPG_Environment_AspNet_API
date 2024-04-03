using HxH_RPG_Environment.Domain.Experiences;
using HxH_RPG_Environment.Domain.Attributes;
using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.Domain.Physicals;

public class PhysicalAttributes
{
  private const double COEFFICIENT = 5.0;
  private readonly Dictionary<AttributeName, IGameAttribute> attributes = [];

  public PhysicalAttributes(ICascadeUpgrade physAbilityExp)
  {
    Experience exp = new(new ExpTable(COEFFICIENT));
    PrimaryAttribute primaryAttribute = new(exp, physAbilityExp);

    PrimaryAttribute constitution = primaryAttribute.Clone();
    PrimaryAttribute strength = primaryAttribute.Clone();
    MiddleAttribute defense = new(exp.Clone(), physAbilityExp, [constitution, strength]);
    attributes.Add(AttributeName.Constitution, constitution);
    attributes.Add(AttributeName.Strength, strength);
    attributes.Add(AttributeName.Defense, defense);

    PrimaryAttribute agility = primaryAttribute.Clone();
    MiddleAttribute velocity = new(exp.Clone(), physAbilityExp, [strength, agility]);
    attributes.Add(AttributeName.Agility, agility);
    attributes.Add(AttributeName.Velocity, velocity);

    PrimaryAttribute dexterity = primaryAttribute.Clone();
    MiddleAttribute actionSpeed = new(exp.Clone(), physAbilityExp, [agility, dexterity]);
    attributes.Add(AttributeName.Dexterity, dexterity);
    attributes.Add(AttributeName.ActionSpeed, actionSpeed);

    PrimaryAttribute sense = primaryAttribute.Clone();
    MiddleAttribute reflex = new(exp.Clone(), physAbilityExp, [dexterity, sense]);
    attributes.Add(AttributeName.Sense, sense);
    attributes.Add(AttributeName.Reflex, reflex);
  }

  // TODO: refactor to throw exception
  public IGameAttribute? Get(AttributeName name)
  {
    attributes.TryGetValue(name, out IGameAttribute? attr);
    return attr;
  }
}