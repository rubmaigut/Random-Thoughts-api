using Microsoft.AspNetCore.Mvc;
using RandomThoughtsApi.Data;

namespace RandomThoughtsApi.Controllers;

[ApiController]
[Route("/[controller]")]
public class ThoughtsController : ControllerBase
{
  private readonly IThoughtsRepository _repository;

  public ThoughtsController(IThoughtsRepository repository)
  {
    _repository = repository;
  }
  
  [HttpGet]
  public ActionResult GetAllMessages()
  {
    return Ok(_repository.GetAll());
  }
}