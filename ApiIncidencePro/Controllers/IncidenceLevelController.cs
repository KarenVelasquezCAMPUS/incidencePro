using Domain.Interfaces;

namespace ApiIncidencePro.Controllers;
public class IncidenceLevelController : BaseApiController
{
    private readonly IUnitOfWork UnitOfWork;

    public IncidenceLevelController(IUnitOfWork unitOfWork)
    {
        this.UnitOfWork = unitOfWork;
    }
}