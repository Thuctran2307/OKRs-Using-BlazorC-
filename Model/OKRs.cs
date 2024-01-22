using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace OKRs.Model
{
    public class OKRs
    {
        [BsonId]
        public string idOKRs { get; set; }

        public string idUser { get; set; }

        public string idCycle { get; set; }

        public bool type { get; set; }

        public string _object { get; set; }

        public string idOKR_Superior { get; set; }

        public int confident { get; set; }

        public long dateCheckIn { get; set; }

        public int status { get; set; }

        public long dateCreate { get; set; }

        public bool isCheckIn { get; set; }


        public OKRs()
        {
            idOKRs = ObjectId.GenerateNewId().ToString();
        }
    }


}