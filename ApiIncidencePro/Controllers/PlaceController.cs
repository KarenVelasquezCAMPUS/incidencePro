using Domain.Interfaces;

namespace ApiIncidencePro.Controllers;
public class PlaceController : BaseApiController
{
    private readonly IUnitOfWork UnitOfWork;

    public PlaceController(IUnitOfWork unitOfWork)
    {
        this.UnitOfWork = unitOfWork;
    }
}