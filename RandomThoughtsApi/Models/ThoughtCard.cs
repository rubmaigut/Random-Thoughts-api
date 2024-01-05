namespace RandomThoughtsApi.Models;

public class ThoughtCard
{ 
        public string Id = Guid.NewGuid().ToString();
    
        public string ThoughtContent { get; set; }
    
        public int Likes { get; set; } = 0;
    
        public string UserId { get; set; }
    
        public DateTime TimeStamp { get; set; } = DateTime.Now;
        
}