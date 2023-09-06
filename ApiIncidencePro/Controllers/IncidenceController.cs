using Domain.Interfaces;

namespace ApiIncidencePro.Controllers;
public class IncidenceController : BaseApiController
{
    private readonly IUnitOfWork UnitOfWork;

    public IncidenceController(IUnitOfWork unitOfWork)
    {
        this.UnitOfWork = unitOfWork;
    }
}