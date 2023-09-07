using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public class ContactCategoryRepository : GenericRepository<ContactCategory>, IContactCategoryRepository
{
    private readonly ApiIncidenceProContext _context;
    public ContactCategoryRepository(ApiIncidenceProContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<ContactCategory>> GetAllAsync()
    {
        return await _context.ContactCategories
                            .ToListAsync();
    }
}