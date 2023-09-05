using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public class AreaUserRepository : GenericRepository<AreaUser>, IAreaUserRepository
{
    public AreaUserRepository(ApiIncidenceProContext context) : base(context)
    {
    }
}