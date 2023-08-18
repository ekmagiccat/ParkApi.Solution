using Microsoft.AspNetCore.Mvc;

namespace ParkApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ParkApiController : ControllerBase
{
    private readonly ParkApiContext _db;

    public ParkApiController(ParkApiContext db)
    {
        _db = db;
    }

}
