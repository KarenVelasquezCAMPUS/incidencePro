namespace Domain.Entities;
public class AreaUser
{
  public int IdUserFk { get; set; }
  public User User { get; set; }
  public int IdAreaFk { get; set; }
  public Area Area { get; set; }
}