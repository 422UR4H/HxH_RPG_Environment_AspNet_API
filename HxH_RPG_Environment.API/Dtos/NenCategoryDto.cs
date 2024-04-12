using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.API.Dtos;

public class NenCategoryDto(NenCategoryName name, ExperienceDto exp)
{
  public NenCategoryName Name { get; set; } = name;
  public ExperienceDto Exp { get; set; } = exp;
}