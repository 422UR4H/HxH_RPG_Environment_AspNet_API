using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.Domain.Attributes;

public class AttributesManager(Dictionary<AttributeName, IGameAttribute> attributes)
{
  public Dictionary<AttributeName, IGameAttribute> Attributes { get; } = attributes;

  // TODO: refactor this exception
  public IGameAttribute Get(AttributeName name)
  {
    return Attributes.GetValueOrDefault(name) ??
      throw new Exception("Attribute not found!");
  }

  public int GetPowerOf(AttributeName name)
  {
    return Get(name).GetPower();
  }
}