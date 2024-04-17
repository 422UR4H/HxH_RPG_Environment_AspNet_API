using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.Application.Dtos;

public class AppAttributesManagerDto(AppAttributeDto[] attributes)
{
  public AppAttributeDto[] Attributes { get; set; } = attributes;

  // TODO: refactor this exception
  public AppAttributeDto Get(AttributeName name)
  {
    return Attributes.FirstOrDefault(a => a.Name == name) ??
      throw new Exception("Attribute not found!");
  }
}