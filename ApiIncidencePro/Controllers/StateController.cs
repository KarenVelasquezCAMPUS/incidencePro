using Domain.Interfaces;

namespace ApiIncidencePro.Controllers;
public class StateController : BaseApiController
{
    private readonly IUnitOfWork UnitOfWork;

    public StateController(IUnitOfWork unitOfWork)
    {
        this.UnitOfWork = unitOfWork;
    }
}