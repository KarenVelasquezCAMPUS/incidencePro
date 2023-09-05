namespace Domain.Entities;
public class IncidenceType
{
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<IncidenceDetail> IncidenceDetails { get; set; }
}