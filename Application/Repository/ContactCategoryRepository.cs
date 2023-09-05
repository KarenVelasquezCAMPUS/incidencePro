using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public class ContactCategoryRepository : GenericRepository<ContactCategory>, IContactCategoryRepository
{
    public ContactCategoryRepository(ApiIncidenceProContext context) : base(context)
    {
    }
}