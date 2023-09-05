namespace Domain.Entities;
public class ContactType
{
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<Contact> Contacts { get; set; }
}