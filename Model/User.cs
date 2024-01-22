using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace OKRs.Model
{
    public class User
    {
        [BsonId]
        public string userId { get; set; }
        public string userName { get; set; }

        public string password { get; set; }

        public string type { get; set; }

        public string idCycle { get; set; }

        public User(){
            this.userId = ObjectId.GenerateNewId().ToString();
        }
    }
}