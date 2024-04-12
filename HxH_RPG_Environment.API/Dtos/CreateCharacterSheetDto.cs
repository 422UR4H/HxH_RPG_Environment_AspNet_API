namespace HxH_RPG_Environment.API.Dtos;

public class CreateCharacterSheetDto(
  ProfileDto profile,
  AbilitiesDto abilities,
  CharacterAttributesDto characterAttributes,
  CharacterSkillsDto skills,
  PrinciplesManagerDto principles,
  StatusManagerDto statusManager)
{
  public ProfileDto Profile { get; set; } = profile;
  public AbilitiesDto Abilities { get; set; } = abilities;
  public CharacterAttributesDto CharacterAttributes { get; set; } = characterAttributes;
  public CharacterSkillsDto Skills { get; set; } = skills;
  public PrinciplesManagerDto Principles { get; set; } = principles;
  public StatusManagerDto StatusManager { get; set; } = statusManager;
}