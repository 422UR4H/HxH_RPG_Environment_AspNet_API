using System.ComponentModel.DataAnnotations;

namespace HxH_RPG_Environment.API.Dtos;

public class InputCharacterSheetDto(
  InputProfileDto profile,
  InputAbilitiesManagerDto abilities,
  InputCharacterAttributesDto characterAttrs,
  InputCharacterSkillsDto characterSkills,
  InputNenPrinciplesManagerDto principles,
  InputStatusManagerDto statusManager)
{
  [Required(ErrorMessage = "Field {0} is mandatory")]
  public InputProfileDto Profile { get; set; } = profile;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public InputAbilitiesManagerDto Abilities { get; set; } = abilities;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public InputCharacterAttributesDto CharacterAttrs { get; set; } = characterAttrs;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public InputCharacterSkillsDto CharacterSkills { get; set; } = characterSkills;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public InputNenPrinciplesManagerDto Principles { get; set; } = principles;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public InputStatusManagerDto StatusManager { get; set; } = statusManager;
}