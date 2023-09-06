using Domain.Interfaces;

namespace ApiIncidencePro.Controllers;
public class RoleController : BaseApiController
{
    private readonly IUnitOfWork UnitOfWork;

    public RoleController(IUnitOfWork unitOfWork)
    {
        this.UnitOfWork = unitOfWork;
    }
}