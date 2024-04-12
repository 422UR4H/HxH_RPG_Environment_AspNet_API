using System.ComponentModel.DataAnnotations;

namespace HxH_RPG_Environment.API.Dtos;

public class PrinciplesManagerDto(NenPrincipleDto[] principle, HatsuDto hatsu)
{
  [Required(ErrorMessage = "Field {0} is mandatory")]
  public NenPrincipleDto[] Principle { get; set; } = principle;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public HatsuDto Hatsu { get; set; } = hatsu;
}