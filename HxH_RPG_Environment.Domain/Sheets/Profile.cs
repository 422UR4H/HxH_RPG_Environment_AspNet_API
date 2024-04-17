namespace HxH_RPG_Environment.Domain.Sheets;

public class Profile(
  string nickname,
  string fullname,
  string? description,
  DateOnly birthday)
{
  public string Nickname { get; set; } = nickname;
  public string Fullname { get; set; } = fullname;
  public string? Description { get; set; } = description;
  public string? BriefDescription { get; set; }
  public DateOnly Birthday { get; } = birthday;
}
