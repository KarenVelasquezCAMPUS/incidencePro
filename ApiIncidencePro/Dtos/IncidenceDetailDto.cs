namespace ApiIncidencePro.Dtos;
public class IncidenceDetailDto
{
  public int IncidenceDetailId { get; set; }
  public string IncidenceDetailDescription { get; set; }
  public List<WorkToolDto> WorkTools { get; set; }
  public List<IncidenceTypeDto> IncidenceTypes { get; set; }
  public List<IncidenceLevelDto> IncidenceLevels { get; set; }
  public List<StateDto> States { get; set; }
}