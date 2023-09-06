using Domain.Interfaces;

namespace ApiIncidencePro.Controllers;
public class IncidenceTypeController : BaseApiController
{
    private readonly IUnitOfWork UnitOfWork;

    public IncidenceTypeController(IUnitOfWork unitOfWork)
    {
        this.UnitOfWork = unitOfWork;
    }
}