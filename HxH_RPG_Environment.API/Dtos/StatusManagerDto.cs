namespace HxH_RPG_Environment.API.Dtos;

public class StatusManagerDto(StatusDto[] status)
{
  // public TestDto[] TestDto { get; set; } = testDto;
  public StatusDto[] Status { get; set; } = status;
}