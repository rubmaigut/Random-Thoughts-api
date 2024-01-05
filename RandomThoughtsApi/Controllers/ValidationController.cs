using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MessageValidator.Controllers;

[ApiController]
[Route("messages/[controller]")]
public class ValidationController : ControllerBase
{

  [HttpGet]
  public ActionResult GetAllMessages()
  {
    return Ok("Is Working");
  }
}