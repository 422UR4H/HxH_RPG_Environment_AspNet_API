using System.ComponentModel.DataAnnotations;

namespace HxH_RPG_Environment.API.Dtos;

public class HatsuDto(ExperienceDto exp, NenCategoryDto[] categories)
{
  [Required(ErrorMessage = "Field {0} is mandatory")]
  public NenCategoryDto[] Categories { get; set; } = categories;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public ExperienceDto Exp { get; set; } = exp;
}