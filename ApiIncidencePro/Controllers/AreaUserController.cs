using Domain.Interfaces;

namespace ApiIncidencePro.Controllers;
public class AreaUserController : BaseApiController
{
    private readonly IUnitOfWork UnitOfWork;

    public AreaUserController(IUnitOfWork unitOfWork)
    {
        this.UnitOfWork = unitOfWork;
    }
}