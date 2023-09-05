namespace Domain.Entities;
public class DocType
{
    public string Name { get; set; }
    public string Abbreviation { get; set; }
    public ICollection<Contact> Contacts { get; set; }
}