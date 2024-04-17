using HxH_RPG_Environment.API.Dtos;
using HxH_RPG_Environment.Application.Dtos;
using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.API.Mappers;

public class PresentNenPrinciplesManagerMapper(
  PresentNenPrincipleMapper principleMapper,
  PresentHatsuMapper hatsuMapper)
{
  private readonly PresentNenPrincipleMapper _principleMapper = principleMapper;
  private readonly PresentHatsuMapper _hatsuMapper = hatsuMapper;

  public AppNenPrinciplesManagerDto ToAppDto(InputNenPrinciplesManagerDto dto)
  {
    ICollection<AppNenPrincipleDto> principles = [];
    foreach (var s in dto.Principles)
    {
      if (s.Name == NenPrincipleName.Hatsu) continue;
      principles.Add(_principleMapper.ToAppDto(s));
    }

    return new AppNenPrinciplesManagerDto(
      [.. principles],
      _hatsuMapper.ToAppDto(dto.Hatsu));
  }
}