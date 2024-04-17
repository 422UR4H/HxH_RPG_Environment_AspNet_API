using HxH_RPG_Environment.API.Dtos;
using HxH_RPG_Environment.Application.Dtos;

namespace HxH_RPG_Environment.API.Mappers;

public class PresentSkillsManagerMapper(
  PresentSkillMapper skillMapper,
  PresentExperienceMapper expMapper)
{
  private readonly PresentSkillMapper _skillMapper = skillMapper;
  private readonly PresentExperienceMapper _expMapper = expMapper;

  public AppSkillsManagerDto ToAppDto(InputSkillsManagerDto dto)
  {
    ICollection<AppSkillDto> skills = [];
    foreach (var s in dto.Skills)
    {
      skills.Add(_skillMapper.ToAppDto(s));
    }
    return new AppSkillsManagerDto(_expMapper.ToAppDto(dto.Exp), [.. skills]);
  }
}