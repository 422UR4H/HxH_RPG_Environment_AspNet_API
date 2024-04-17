using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.Domain.Attributes;

public class CharacterAttributes(
  AttributesManager physicalAttributes,
  AttributesManager mentalAttributes,
  AttributesManager spiritualAttributes)
{
  public AttributesManager PhysicalAttributes { get; } = physicalAttributes;
  public AttributesManager MentalAttributes { get; } = mentalAttributes;
  public AttributesManager SpiritualAttributes { get; } = spiritualAttributes;

  // TODO: refactor this exception
  public IGameAttribute Get(AttributeName name)
  {
    return SpiritualAttributes.Get(name) ??
      PhysicalAttributes.Get(name) ??
      MentalAttributes.Get(name) ??
      throw new Exception("Attribute not found!");
  }

  public int GetPointsOf(AttributeName name)
  {
    return Get(name).Points;
  }

  public int GetExpPointsOf(AttributeName name)
  {
    return Get(name).GetExpPoints();
  }

  public int GetLevelOf(AttributeName name)
  {
    return Get(name).GetLevel();
  }

  public void SetPoints(int points, AttributeName name)
  {
    PrimaryAttribute attr = PhysicalAttributes.GetPrimary(name) ??
      MentalAttributes.GetPrimary(name) ??
      throw new Exception("Primary Attribute not found!");

    attr.Points = points;
  }

  public int GetPowerOf(AttributeName name)
  {
    return Get(name).GetPower();
  }
}