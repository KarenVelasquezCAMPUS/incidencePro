using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public class UserRepository : GenericRepository<User>, IUserRepository
{
    public UserRepository(ApiIncidenceProContext context) : base(context)
    {
    }
}