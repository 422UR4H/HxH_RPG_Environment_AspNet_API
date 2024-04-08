using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.Domain.Attributes;

public class CharacterAttributes(
  AttributesManager physicalAttributes,
  AttributesManager mentalAttributes)
{
  public AttributesManager PhysicalAttributes { get; } = physicalAttributes;
  public AttributesManager MentalAttributes { get; } = mentalAttributes;

  // TODO: refactor this method
  public IGameAttribute Get(AttributeName name)
  {
    IGameAttribute attr;
    try
    {
      attr = PhysicalAttributes.Get(name);
    }
    catch (Exception)
    {
      attr = MentalAttributes.Get(name) ??
        throw new Exception("Attribute not found!");
    }
    return attr;
  }

  public int GetPowerOf(AttributeName name)
  {
    return Get(name).GetPower();
  }
}