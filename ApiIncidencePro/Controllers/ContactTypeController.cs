using Domain.Interfaces;

namespace ApiIncidencePro.Controllers;
public class ContactTypeController : BaseApiController
{
    private readonly IUnitOfWork UnitOfWork;

    public ContactTypeController(IUnitOfWork unitOfWork)
    {
        this.UnitOfWork = unitOfWork;
    }
}