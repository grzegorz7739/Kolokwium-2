using Kolokwium2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium2.Controllers;


[ApiController]
[Route("api/[controller]")]
public class BackpackController : ControllerBase
{
    private readonly IDbService _dbService;
    public BackpackController(IDbService dbService)
    {
        _dbService = dbService;
    }
}