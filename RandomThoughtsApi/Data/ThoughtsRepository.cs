using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using RandomThoughtsApi.Models;

namespace RandomThoughtsApi.Data;

public class ThoughtsRepository: IThoughtsRepository
{
    private readonly List<PostThought> _repo;
    
    public IEnumerable<PostThought> GetAll() => _repo;
}