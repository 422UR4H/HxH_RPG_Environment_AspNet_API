using HxH_RPG_Environment.API.Dtos;
using HxH_RPG_Environment.Application.Dtos;

namespace HxH_RPG_Environment.API.Mappers;

public class PresentCharacterSkillsMapper(
  PresentSkillsManagerMapper mapper)
{
  private readonly PresentSkillsManagerMapper _mapper = mapper;

  public AppCharacterSkillsDto ToAppDto(InputCharacterSkillsDto dto)
  {
    return new AppCharacterSkillsDto(
      _mapper.ToAppDto(dto.PhysicalSkills),
      _mapper.ToAppDto(dto.MentalSkills),
      _mapper.ToAppDto(dto.SpiritualSkills));
  }
}