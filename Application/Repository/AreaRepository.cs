using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public class AreaRepository : GenericRepository<Area>, IAreaRepository
{
    public AreaRepository(ApiIncidenceProContext context) : base(context)
    {
    }
}