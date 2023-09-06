using Domain.Interfaces;

namespace ApiIncidencePro.Controllers;

public class WorkToolController : BaseApiController
{
    private readonly IUnitOfWork UnitOfWork;

    public WorkToolController(IUnitOfWork unitOfWork)
    {
        this.UnitOfWork = unitOfWork;
    }
}