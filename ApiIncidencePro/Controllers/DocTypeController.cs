using Domain.Interfaces;

namespace ApiIncidencePro.Controllers;
public class DocTypeController : BaseApiController
{
    private readonly IUnitOfWork UnitOfWork;

    public DocTypeController(IUnitOfWork unitOfWork)
    {
        this.UnitOfWork = unitOfWork;
    }
}