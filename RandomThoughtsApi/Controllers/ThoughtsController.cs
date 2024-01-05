using Microsoft.AspNetCore.Mvc;
using RandomThoughtsApi.Data;
using RandomThoughtsApi.Models;

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
  public ActionResult<IEnumerable<ThoughtCard>> GetAllMessages()
  {
    return Ok(_repository.GetAll());
  }

  [HttpPost]
  public ActionResult<ThoughtCard> PostMessage([FromBody] ThoughtCard thought)
  {
    var newThought = _repository.AddThought(thought);
    return CreatedAtAction(nameof(GetAllMessages), new { id = newThought.Id }, newThought);
  }
}