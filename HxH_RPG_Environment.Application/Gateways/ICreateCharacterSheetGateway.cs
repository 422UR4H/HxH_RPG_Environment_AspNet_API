using HxH_RPG_Environment.Domain.Sheets;

namespace HxH_RPG_Environment.Application.Gateways;

public interface ICreateCharacterSheetGateway
{
  public CharacterSheet CreateCharacterSheet(CharacterSheet characterSheet);
}