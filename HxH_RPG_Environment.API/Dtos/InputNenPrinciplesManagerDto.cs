using System.ComponentModel.DataAnnotations;

namespace HxH_RPG_Environment.API.Dtos;

public class InputNenPrinciplesManagerDto(InputNenPrincipleDto[] principles, InputHatsuDto hatsu)
{
  [Required(ErrorMessage = "Field {0} is mandatory")]
  public InputNenPrincipleDto[] Principles { get; set; } = principles;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public InputHatsuDto Hatsu { get; set; } = hatsu;
}