using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace OKRs.Model
{
    public class Process{


        [BsonId]
        public string idProcess { get; set; }
        public string idOKRs { get; set; }
        public long date { get; set; }
        public double process { get; set; }

        public int type { get; set; }


        public Process(){
            idProcess = ObjectId.GenerateNewId().ToString();
        }
    }
}