using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public class IncidenceRepository : GenericRepository<Incidence>, IIncidenceRepository
{
    public IncidenceRepository(ApiIncidenceProContext context) : base(context)
    {
    }
}