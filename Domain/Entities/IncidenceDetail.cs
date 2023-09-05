namespace Domain.Entities;
public class IncidenceDetail
{
    public string Description { get; set; }
    public int IdWorkToolFk { get; set; }
    public int IdIncidenceDetailFk { get; set; }
    public int IdIncidenceLevelFk { get; set; }
    public int IdStateFk { get; set; }
    public WorkTool WorkTool { get; set; }
    public ICollection<WorkTool> WorkTools { get; set; }
}