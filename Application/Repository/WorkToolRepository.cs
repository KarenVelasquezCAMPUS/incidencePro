using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public class WorkToolRepository : GenericRepository<WorkTool>, IWorkToolRepository
{
    private readonly ApiIncidenceProContext _context;
    public WorkToolRepository(ApiIncidenceProContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<WorkTool>> GetAllAsync()
    {
        return await _context.WorkTools
                            .Include(a => a.IncidenceDetails)
                            .ToListAsync();
    }
}