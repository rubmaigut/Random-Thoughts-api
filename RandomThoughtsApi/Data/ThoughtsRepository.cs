using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using RandomThoughtsApi.Models;

namespace RandomThoughtsApi.Data;

public class ThoughtsRepository: IThoughtsRepository
{
    private readonly List<ThoughtCard> _repo = new List<ThoughtCard>();

    public ThoughtsRepository()
    {
        _repo.Add(new ThoughtCard
        {
            UserId = "Developer",
            ThoughtContent = " Welcome to this app, post your random thoughts."
        });
    }
    
    public IEnumerable<ThoughtCard> GetAll() => _repo;

    public ThoughtCard AddThought(ThoughtCard thought)
    {
        _repo.Add(thought);
        return thought;
    }

    public void UpdateLikes(string id)
    {
        var thought = _repo.FirstOrDefault(t => t.Id == id);
        if (thought != null)
        {
            thought.Likes += 1;
        }
    }

    public IEnumerable<ThoughtCard> GetByUser(string userId)
    {
        return _repo.Where(user => user.UserId == userId);
    }
}