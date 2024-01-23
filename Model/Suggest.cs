using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace OKRs.Model
{
    public class Suggest
    {
        [BsonId]
        public string idSuggest { get; set; }

        public string content { get; set; }

        public string idUserSend { get; set; }

        public string idUserRecive { get; set; }

        public bool isSend { get; set; }

        public string reason { get; set; }

        public long dateSend { get; set; }

        public Suggest(){
            this.idSuggest = ObjectId.GenerateNewId().ToString();
        }
    }
}