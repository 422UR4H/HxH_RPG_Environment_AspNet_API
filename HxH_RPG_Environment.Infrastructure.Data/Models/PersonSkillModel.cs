namespace HxH_RPG_Environment.Infrastructure.Data.Models;

public class PersonSkillModel(ExperienceModel exp) : BaseModel
{
  public ExperienceModel Exp { get; set; } = exp;
  // public AttributeId ??
}