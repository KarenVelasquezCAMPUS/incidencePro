using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiIncidencePro.Controllers;
public class AreaController : BaseApiController
{
    private readonly IUnitOfWork UnitOfWork;

    public AreaController(IUnitOfWork unitOfWork)
    {
        this.UnitOfWork = unitOfWork;
    }

    
}