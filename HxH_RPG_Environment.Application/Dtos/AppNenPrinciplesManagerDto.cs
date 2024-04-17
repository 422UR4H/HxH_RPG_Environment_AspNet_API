using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.Application.Dtos;

public class AppNenPrinciplesManagerDto(
  AppNenPrincipleDto[] principles,
  AppHatsuDto hatsu)
{
  public AppNenPrincipleDto[] Principles { get; set; } = principles;
  public AppHatsuDto Hatsu { get; set; } = hatsu;

  // TODO: refactor this exception
  public AppNenPrincipleDto Get(NenPrincipleName name)
  {
    return Principles.FirstOrDefault(a => a.Name == name) ??
      throw new Exception("Nen Principle not found!");
  }

  public int GetExpPointsOf(NenPrincipleName name)
  {
    return Get(name).GetExpPoints();
  }

  public int GetExpPointsOf(NenCategoryName name)
  {
    return Hatsu.GetExpPointsOf(name);
  }

  public int GetLevelOf(NenPrincipleName name)
  {
    return Get(name).GetLevel();
  }

  public int GetLevelOf(NenCategoryName name)
  {
    return Hatsu.GetLevelOf(name);
  }
}