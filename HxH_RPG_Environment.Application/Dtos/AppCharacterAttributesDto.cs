using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.Application.Dtos;

public class AppCharacterAttributesDto(
  AppAttributesManagerDto physicAttrs,
  AppAttributesManagerDto mentasAttrs,
  AppAttributesManagerDto spiritAttrs)
{
  public AppAttributesManagerDto PhysicAttrs { get; set; } = physicAttrs;
  public AppAttributesManagerDto MentalAttrs { get; set; } = mentasAttrs;
  public AppAttributesManagerDto SpiritAttrs { get; set; } = spiritAttrs;

  // TODO: refactor this exception
  public AppAttributeDto Get(AttributeName name)
  {
    return SpiritAttrs.Get(name) ??
      PhysicAttrs.Get(name) ??
      MentalAttrs.Get(name) ??
      throw new Exception("Skill not found!");
  }

  public int GetExpPointsOf(AttributeName name)
  {
    return Get(name).GetExpPoints();
  }

  public int GetLevelOf(AttributeName name)
  {
    return Get(name).GetLevel();
  }

  public int GetPoints(AttributeName name)
  {
    return Get(name).Points;
  }
}