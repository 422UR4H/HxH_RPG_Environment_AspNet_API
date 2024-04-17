using HxH_RPG_Environment.API.Dtos;
using HxH_RPG_Environment.Application.Dtos;

namespace HxH_RPG_Environment.API.Mappers;

public class PresentCharacterAttributesMapper(
  PresentAttributesManagerMapper mapper)
{
  private readonly PresentAttributesManagerMapper _mapper = mapper;

  public AppCharacterAttributesDto ToAppDto(InputCharacterAttributesDto dto)
  {
    return new AppCharacterAttributesDto(
      _mapper.ToAppDto(dto.PhysicAttributes),
      _mapper.ToAppDto(dto.MentalAttributes),
      _mapper.ToAppDto(dto.SpiritAttributes));
  }
}