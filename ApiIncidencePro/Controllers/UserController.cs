using Domain.Interfaces;

namespace ApiIncidencePro.Controllers;
public class UserController : BaseApiController
{
    private readonly IUnitOfWork UnitOfWork;

    public UserController(IUnitOfWork unitOfWork)
    {
        this.UnitOfWork = unitOfWork;
    }
}