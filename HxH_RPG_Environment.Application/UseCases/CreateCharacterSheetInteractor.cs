using HxH_RPG_Environment.Application.Dtos;
using HxH_RPG_Environment.Application.Gateways;
using HxH_RPG_Environment.Domain.Enums;
using HxH_RPG_Environment.Domain.Sheets;
using HxH_RPG_Environment.Domain.Status;

namespace HxH_RPG_Environment.Application.UseCases;

public class CreateCharacterSheetInteractor(ICreateCharacterSheetGateway gateway)
{
  private readonly ICreateCharacterSheetGateway _gateway = gateway;

  public CharacterSheet CreateCharacterSheet(
    Profile profile,
    AppAbilitiesManagerDto abilities,
    AppCharacterAttributesDto attributes,
    AppCharacterSkillsDto skills,
    AppNenPrinciplesManagerDto principles,
    StatusManager status)
  {
    CharacterSheet characterSheet = new CharacterSheetFactory().Build(profile);

    foreach (AttributeName name in Enum.GetValues(typeof(AttributeName)))
    {
      int points = attributes.GetPoints(name);
      characterSheet.Attributes.SetPoints(points, name);
    }

    foreach (SkillName name in Enum.GetValues(typeof(SkillName)))
    {
      int points = skills.GetExpPointsOf(name);
      characterSheet.IncreaseExp(points, name);
    }

    foreach (NenCategoryName name in Enum.GetValues(typeof(NenCategoryName)))
    {
      int points = principles.GetExpPointsOf(name);
      characterSheet.IncreaseExp(points, name);
    }

    foreach (NenPrincipleName name in Enum.GetValues(typeof(NenPrincipleName)))
    {
      if (name == NenPrincipleName.Hatsu) continue;

      int points = principles.GetExpPointsOf(name);
      characterSheet.IncreaseExp(points, name);
    }

    foreach (AbilityName name in Enum.GetValues(typeof(AbilityName)))
    {
      int expectedLvl = abilities.GetLevelOf(name);
      int currentLvl = characterSheet.GetLevelOf(name);
      if (expectedLvl != currentLvl)
      {
        // TODO: generate log
        Console.WriteLine($"{name} - expectedLvl: {expectedLvl}, currentLvl: {currentLvl}");
      }

      int expectedExp = abilities.GetExpPointsOf(name);
      int currentExp = characterSheet.GetExpPointsOf(name);
      if (expectedExp != currentExp)
      {
        // TODO: generate log
        Console.WriteLine($"{name} - expectedExp: {expectedExp}, currentExp: {currentExp}");
      }
    }

    foreach (AttributeName name in Enum.GetValues(typeof(AttributeName)))
    {
      int expectedLvl = attributes.GetLevelOf(name);
      int currentLvl = characterSheet.GetLevelOf(name);
      if (expectedLvl != currentLvl)
      {
        // TODO: generate log
        Console.WriteLine($"{name} - expectedLvl: {expectedLvl}, currentLvl: {currentLvl}");
      }

      int expectedExp = attributes.GetExpPointsOf(name);
      int currentExp = characterSheet.GetExpPointsOf(name);
      if (expectedExp != currentExp)
      {
        // TODO: generate log
        Console.WriteLine($"{name} - expectedExp: {expectedExp}, currentExp: {currentExp}");
      }
    }

    foreach (NenPrincipleName name in Enum.GetValues(typeof(NenPrincipleName)))
    {
      int expectedLvl = principles.GetLevelOf(name);
      int currentLvl = characterSheet.GetLevelOf(name);
      if (expectedLvl != currentLvl)
      {
        // TODO: generate log
        Console.WriteLine($"{name} - expectedLvl: {expectedLvl}, currentLvl: {currentLvl}");
      }

      int expectedExp = principles.GetExpPointsOf(name);
      int currentExp = characterSheet.GetExpPointsOf(name);
      if (expectedExp != currentExp)
      {
        // TODO: generate log
        Console.WriteLine($"{name} - expectedExp: {expectedExp}, currentExp: {currentExp}");
      }
    }

    foreach (SkillName name in Enum.GetValues(typeof(SkillName)))
    {
      int expectedLvl = skills.GetLevelOf(name);
      int currentLvl = characterSheet.GetLevelOf(name);
      if (expectedLvl != currentLvl)
      {
        // TODO: generate log
        Console.WriteLine($"{name} - expectedLvl: {expectedLvl}, currentLvl: {currentLvl}");
      }
    }

    foreach (StatusName name in Enum.GetValues(typeof(StatusName)))
    {
      int expectedMax = status.GetMaxOf(name);
      int currentMax = characterSheet.GetMaxOf(name);
      if (expectedMax != currentMax)
      {
        // TODO: generate log
        Console.WriteLine($"{name} - expectedMax: {expectedMax}, currentMax: {currentMax}");
      }

      int expectedMin = status.GetMinOf(name);
      int currentMin = characterSheet.GetMinOf(name);
      if (expectedMin != currentMin)
      {
        // TODO: generate log
        Console.WriteLine($"{name} - expectedMin: {expectedMin}, currentMin: {currentMin}");
      }
    }

    return _gateway.CreateCharacterSheet(characterSheet);
  }

  // TODO: refactor managers abstracting to interface to refactor above function
  // private void Validate(CharacterSheet characterSheet, )
}