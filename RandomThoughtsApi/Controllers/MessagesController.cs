using Microsoft.AspNetCore.Mvc;

namespace RandomThoughtsApi.Controllers;

[ApiController]
[Route("/[controller]")]
public class MessagesController : ControllerBase
{

  [HttpGet]
  public ActionResult GetAllMessages()
  {
    return Ok("Is Working");
  }
}