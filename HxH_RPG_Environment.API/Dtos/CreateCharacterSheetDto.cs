using System.ComponentModel.DataAnnotations;

namespace HxH_RPG_Environment.API.Dtos;

public class CreateCharacterSheetDto(
  ProfileDto profile,
  AbilitiesDto abilities,
  CharacterAttributesDto characterAttrs,
  CharacterSkillsDto skills,
  PrinciplesManagerDto principles,
  StatusManagerDto statusManager)
{
  [Required(ErrorMessage = "Field {0} is mandatory")]
  public ProfileDto Profile { get; set; } = profile;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public AbilitiesDto Abilities { get; set; } = abilities;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public CharacterAttributesDto CharacterAttrs { get; set; } = characterAttrs;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public CharacterSkillsDto Skills { get; set; } = skills;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public PrinciplesManagerDto Principles { get; set; } = principles;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public StatusManagerDto StatusManager { get; set; } = statusManager;
}