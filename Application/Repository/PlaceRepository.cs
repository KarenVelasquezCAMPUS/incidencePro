using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public class PlaceRepository : GenericRepository<Place>, IPlaceRepository
{
    public PlaceRepository(ApiIncidenceProContext context) : base(context)
    {
    }
}