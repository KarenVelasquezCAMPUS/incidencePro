using Domain.Interfaces;

namespace ApiIncidencePro.Controllers;
public class IncidenceDetailController : BaseApiController
{
    private readonly IUnitOfWork UnitOfWork;

    public IncidenceDetailController(IUnitOfWork unitOfWork)
    {
        this.UnitOfWork = unitOfWork;
    }
}