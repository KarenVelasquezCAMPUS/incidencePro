namespace Domain.Entities;
public class Area : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; } 
    public ICollection<AreaUser> AreaUsers { get; set; }
    public ICollection<Place> Places { get; set; }
}