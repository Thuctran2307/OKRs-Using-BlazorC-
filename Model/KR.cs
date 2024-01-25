using MongoDB.Bson.Serialization.Attributes;

namespace OKRs.Model
{
    public class KR
    {
        [BsonId]
        public string idKR { get; set; }

        public string idOKRs { get; set; }

        public string _keyResult { get; set; }

        public long target { get; set; }

        public long processCurrent { get; set; }

        public int confident { get; set; }

        public string unit{ get; set; }

        public string  linkResult { get; set; }

        public string idUserCross { get; set; }

        public List<string> answers { get; set; }

        public KR()
        {
            idKR = MongoDB.Bson.ObjectId.GenerateNewId().ToString();
            answers = new List<string>();
        }
    }
}