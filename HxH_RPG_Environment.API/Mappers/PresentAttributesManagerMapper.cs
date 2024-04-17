using HxH_RPG_Environment.API.Dtos;
using HxH_RPG_Environment.Application.Dtos;

namespace HxH_RPG_Environment.API.Mappers;

public class PresentAttributesManagerMapper(PresentAttributeMapper mapper)
{
  private readonly PresentAttributeMapper _attributeMapper = mapper;

  public AppAttributesManagerDto ToAppDto(InputAttributesManagerDto dto)
  {
    ICollection<AppAttributeDto> attrs = [];
    foreach (var s in dto.Attributes)
    {
      attrs.Add(_attributeMapper.ToAppDto(s));
    }
    return new AppAttributesManagerDto([.. attrs]);
  }
}