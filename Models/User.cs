using System.Collections.Generic;

namespace CarTest.Models
{
    public class BasicUser
    {
       public int Id { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }
    }
    public class User 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public ICollection<Car> Cars { get; set; }
        public string FaceBookUserId { get; set; }        
        public string RecipientId { get; set; }
        public string ServiceUrl { get; set; }
        public string ChannelId { get; set; }
        public string ConversationId { get; set; }
    }
}
