using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public class StateRepository : GenericRepository<State>, IStateRepository
{
    public StateRepository(ApiIncidenceProContext context) : base(context)
    {
    }
}