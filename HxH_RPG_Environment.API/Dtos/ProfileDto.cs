using System.ComponentModel.DataAnnotations;

namespace HxH_RPG_Environment.API.Dtos;

public class ProfileDto(
  string nickname,
  string fullname,
  string? description,
  DateTime birthday)
{
  [Required(ErrorMessage = "Field nickname is mandatory")]
  public string Nickname { get; set; } = nickname;

  [Required(ErrorMessage = "Field fullname is mandatory")]
  public string Fullname { get; set; } = fullname;

  public string? Description { get; set; } = description;

  [DataType(DataType.Date)]
  [Required(ErrorMessage = "Field birthday is mandatory")]
  public DateTime Birthday { get; set; } = birthday;
}