using System.ComponentModel.DataAnnotations;

namespace RandomThoughtsApi.Models;

public class PostThought
{
    public PostThought()
    {
        Thoughts = new List<ThoughtCard>();
    }
    
    public List<ThoughtCard> Thoughts { get; }
}