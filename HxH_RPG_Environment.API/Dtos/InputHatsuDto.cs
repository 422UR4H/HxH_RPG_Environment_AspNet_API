using System.ComponentModel.DataAnnotations;

namespace HxH_RPG_Environment.API.Dtos;

public class InputHatsuDto(InputExperienceDto exp, InputNenCategoryDto[] categories)
{
  [Required(ErrorMessage = "Field {0} is mandatory")]
  public InputExperienceDto Exp { get; set; } = exp;

  [Required(ErrorMessage = "Field {0} is mandatory")]
  public InputNenCategoryDto[] Categories { get; set; } = categories;
}