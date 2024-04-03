using HxH_RPG_Environment.Domain.Experiences;
using HxH_RPG_Environment.Domain.Attributes;
using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.Domain.Mentals;

public class MentalAttributes
{
  private const double COEFFICIENT = 3.0;
  private readonly Dictionary<AttributeName, IGameAttribute> attributes = [];

  public MentalAttributes(ICascadeUpgrade mentalAbilityExp)
  {
    Experience exp = new(new ExpTable(COEFFICIENT));
    PrimaryAttribute attribute = new(exp, mentalAbilityExp);

    attributes.Add(AttributeName.Resilience, attribute.Clone());
    attributes.Add(AttributeName.Adaptability, attribute.Clone());
    attributes.Add(AttributeName.Weighting, attribute.Clone());
    attributes.Add(AttributeName.Creativity, attribute.Clone());
  }

  // TODO: refactor to throw exception
  public IGameAttribute? Get(AttributeName name)
  {
    attributes.TryGetValue(name, out IGameAttribute? attr);
    return attr;
  }
}