using MongoDB.Bson.Serialization.Attributes;

namespace OKRs.Model
{
    public class EvaluateOKRs
    {
        [BsonId]
        public string idEvaluateOKRs { get; set; }

        public string idOKRs { get; set; }

        public string scoreSystem { get; set; }

        public string scoreBySelf { get; set; }

        public string scoreByManager { get; set; }

        public string idUser { get; set; }

        public string idManager { get; set; }

        public long dateEvaluate { get; set; }

        public bool isValuate { get; set; }
    }
}