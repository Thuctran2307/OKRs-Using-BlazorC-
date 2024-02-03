using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace OKRs.Model
{
    public class Chat
    {
        public string userName { get; set; }
        public string message { get; set; }

        public Chat(string userName, string message){
            this.userName = userName;
            this.message = message;
        }
    }
}