using RandomThoughtsApi.Models;

namespace RandomThoughtsApi.Data;

public interface IThoughtsRepository
{
   IEnumerable<ThoughtCard> GetAll(); 
   //List<ThoughtCard> GetByUser(string userId);
   
}