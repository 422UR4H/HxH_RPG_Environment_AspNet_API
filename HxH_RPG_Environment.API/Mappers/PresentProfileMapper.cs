using System.ComponentModel;
using HxH_RPG_Environment.API.Dtos;
using HxH_RPG_Environment.Domain.Sheets;

namespace HxH_RPG_Environment.API.Mappers;

public class PresentProfileMapper
{
  public Profile ToDomainObj(InputProfileDto dto)
  {
    var birthday = new DateOnlyConverter().ConvertTo(dto.Birthday, typeof(DateOnly)) ??
      throw new Exception("Birthday cannot be null");

    return new Profile(dto.Nickname, dto.Fullname, dto.Description, (DateOnly)birthday);
  }
}