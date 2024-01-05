using RandomThoughtsApi.Models;

namespace RandomThoughtsApi.Data;

public interface IThoughtsRepository
{
   IEnumerable<ThoughtCard> GetAll();

   ThoughtCard AddThought(ThoughtCard thought);

   void UpdateLikes(string id);
   
   IEnumerable<ThoughtCard> GetByUser(string userId);

}