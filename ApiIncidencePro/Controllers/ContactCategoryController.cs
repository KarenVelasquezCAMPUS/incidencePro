using Domain.Interfaces;

namespace ApiIncidencePro.Controllers;
public class ContactCategoryController : BaseApiController
{
    private readonly IUnitOfWork UnitOfWork;

    public ContactCategoryController(IUnitOfWork unitOfWork)
    {
        this.UnitOfWork = unitOfWork;
    }
}