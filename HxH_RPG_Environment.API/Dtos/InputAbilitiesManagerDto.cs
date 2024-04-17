using System.ComponentModel.DataAnnotations;
using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.API.Dtos;

// TODO: refactor to use list with names inside InputAbilityDtos
public class InputAbilitiesManagerDto(
  InputAbilityDto[] abilities,
  InputTalentDto talent)
{
  [Required(ErrorMessage = "Field {0} is mandatory")]
  public InputAbilityDto[] Abilities { get; set; } = abilities;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public InputTalentDto Talent { get; set; } = talent;

  // TODO: refactor this exception
  public InputAbilityDto Get(AbilityName name)
  {
    return Abilities.FirstOrDefault(a => a.Name == name) ??
      throw new Exception("Ability not found!");
  }
}