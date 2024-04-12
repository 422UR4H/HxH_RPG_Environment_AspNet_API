namespace HxH_RPG_Environment.API.Dtos;

public class PrinciplesManagerDto(NenPrincipleDto[] principle, HatsuDto hatsu)
{
  public NenPrincipleDto[] Principle { get; set; } = principle;
  public HatsuDto Hatsu { get; set; } = hatsu;
}