using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public class DocTypeRepository : GenericRepository<DocType>, IDocTypeRepository
{
    private readonly ApiIncidenceProContext _context;
    public DocTypeRepository(ApiIncidenceProContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<DocType>> GetAllAsync()
    {
        return await _context.DocTypes
                            .Include(a => a.Contacts)
                            .Include(a => a.Users)
                            .ToListAsync();
    }
}