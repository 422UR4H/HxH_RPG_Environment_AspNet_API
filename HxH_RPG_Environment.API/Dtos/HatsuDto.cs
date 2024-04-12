namespace HxH_RPG_Environment.API.Dtos;

public class HatsuDto(ExperienceDto exp, NenCategoryDto[] categories)
{
  public NenCategoryDto[] Categories { get; set; } = categories;
  public ExperienceDto Exp { get; set; } = exp;
}