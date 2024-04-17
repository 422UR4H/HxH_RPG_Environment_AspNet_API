using HxH_RPG_Environment.API.Dtos;
using HxH_RPG_Environment.Application.Dtos;
using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.API.Mappers;

public class PresentAbilitiesManagerMapper(
  PresentAbilityMapper abilityMapper,
  PresentTalentMapper talentMapper)
{
  private readonly PresentAbilityMapper _abilityMapper = abilityMapper;
  private readonly PresentTalentMapper _talentMapper = talentMapper;

  // TODO: refactor these exception
  public AppAbilitiesManagerDto ToAppDto(InputAbilitiesManagerDto dto)
  {
    var physic = dto.Abilities.FirstOrDefault(a => a.Name == AbilityName.PHYSICALS)
      ?? throw new Exception("Physical Abilities not found!");
    AppAbilityDto physicAbility = _abilityMapper.ToAppDto(physic);

    var mental = dto.Abilities.FirstOrDefault(a => a.Name == AbilityName.MENTALS)
      ?? throw new Exception("Mental Abilities not found!");
    AppAbilityDto mentalAbility = _abilityMapper.ToAppDto(mental);

    var spirit = dto.Abilities.FirstOrDefault(a => a.Name == AbilityName.SPIRITUALS)
      ?? throw new Exception("Spiritual Abilities not found!");
    AppAbilityDto spiritAbility = _abilityMapper.ToAppDto(spirit);

    AppTalentDto talent = _talentMapper.ToAppDto(dto.Talent);
    return new AppAbilitiesManagerDto([physicAbility, mentalAbility, spiritAbility], talent);
  }
}