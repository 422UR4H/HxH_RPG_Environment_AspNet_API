using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.Application.Dtos;

public class AppAbilitiesManagerDto(
  AppAbilityDto[] abilities,
  AppTalentDto talent)
{
  public AppAbilityDto[] Abilities { get; set; } = abilities;
  public AppTalentDto Talent { get; set; } = talent;

  // TODO: refactor this exception
  public AppAbilityDto Get(AbilityName name)
  {
    return Abilities.FirstOrDefault(a => a.Name == name) ??
      throw new Exception("Ability not found!");
  }

  public int GetExpPointsOf(AbilityName name)
  {
    return Get(name).GetExpPoints();
  }

  public int GetLevelOf(AbilityName name)
  {
    return Get(name).GetLevel();
  }
}