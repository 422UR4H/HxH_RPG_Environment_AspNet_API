using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.Domain.Attributes;

public class AttributesManager(
  Dictionary<AttributeName, PrimaryAttribute> primaryAttributes,
  Dictionary<AttributeName, MiddleAttribute> middleAttributes)
{
  public Dictionary<AttributeName, PrimaryAttribute> PrimaryAttributes { get; } =
    primaryAttributes;

  public Dictionary<AttributeName, MiddleAttribute> MiddleAttributes { get; } =
    middleAttributes;

  public Dictionary<AttributeName, IGameAttribute> Attributes
  {
    get
    {
      Dictionary<AttributeName, IGameAttribute> attributes = [];

      foreach (var i in PrimaryAttributes)
      {
        attributes.Add(i.Key, i.Value);
      }
      foreach (var i in MiddleAttributes)
      {
        attributes.Add(i.Key, i.Value);
      }
      return attributes;
    }
  }

  public IGameAttribute? Get(AttributeName name)
  {
    IGameAttribute? attribute = PrimaryAttributes.GetValueOrDefault(name);
    attribute ??= MiddleAttributes.GetValueOrDefault(name);
    return attribute;
  }

  public PrimaryAttribute? GetPrimary(AttributeName name)
  {
    return PrimaryAttributes.GetValueOrDefault(name);
  }

  // TODO: refactor this exception
  public int GetPowerOf(AttributeName name)
  {
    return Get(name)?.GetPower() ??
      throw new Exception("Attribute not found!");
  }
}