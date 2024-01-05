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
}