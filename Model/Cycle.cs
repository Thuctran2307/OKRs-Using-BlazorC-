using MongoDB.Bson.Serialization.Attributes;

namespace OKRs.Model
{
    public class Cycle
    {
        [BsonId]
        public string idCycle { get; set; }
        public string nameCycle { get; set; }

        public long dateStart { get; set; }

        public long dateEnd { get; set; }

        public bool status { get; set; }
    }
}