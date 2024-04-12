namespace HxH_RPG_Environment.API.Dtos;

public class CharacterAttributesDto(
  AttributeDto[] physicAttributes,
  AttributeDto[] mentalAttributes,
  AttributeDto[] spiritAttributes)
{
  public AttributeDto[] PhysicAttributes { get; } = physicAttributes;
  public AttributeDto[] MentalAttributes { get; } = mentalAttributes;
  public AttributeDto[] SpiritAttributes { get; } = spiritAttributes;
}