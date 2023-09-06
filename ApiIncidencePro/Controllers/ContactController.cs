using Domain.Interfaces;

namespace ApiIncidencePro.Controllers;
public class ContactController : BaseApiController
{
    private readonly IUnitOfWork UnitOfWork;

    public ContactController(IUnitOfWork unitOfWork)
    {
        this.UnitOfWork = unitOfWork;
    }
}