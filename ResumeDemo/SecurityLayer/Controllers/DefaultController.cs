using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SecurityLayer.Dal;

namespace SecurityLayer.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DefaultController : ControllerBase
{
    [HttpGet("[action]")]
    public IActionResult Login()
    {
        return Created("", new BuildToken().CreateToken());
    }

    [Authorize]
    [HttpGet("[action]")]
    public IActionResult Page1()
    {
        return Ok("Sayfa1 için girişiniz başarılı");
    }
}