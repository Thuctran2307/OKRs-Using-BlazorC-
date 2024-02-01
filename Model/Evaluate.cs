using MongoDB.Bson.Serialization.Attributes;

namespace OKRs.Model
{
    public class Evaluate
    {
        [BsonId]
        public string idEvaluate { get; set; }

        public string idUser { get; set; }

        public OKRs okr { get; set; }

        public List<KR> krs { get; set; }

        public Dictionary<string, string> dict_comment { get; set; }
        public Dictionary<string, string> dict_response_manager { get; set; }

        public string response { get; set; }

        public Dictionary<string, double> dict_scoreSystem { get; set; }

        public Dictionary<string, double> dict_scoreBySelf { get; set; }

        public Dictionary<string, double> dict_scoreByManager { get; set; }

        public string idManager { get; set; }

        public List<string> listIdUserView {get; set;}

        public long dateCreate { get; set; }
        public long dateReview { get; set; }

        public int status { get; set; }

        // constructore
        public Evaluate()
        {
            idEvaluate = MongoDB.Bson.ObjectId.GenerateNewId().ToString();
            dict_comment = new Dictionary<string, string>();
            dict_scoreSystem = new Dictionary<string, double>();
            dict_scoreBySelf = new Dictionary<string, double>();
            dict_scoreByManager = new Dictionary<string, double>();
            dict_response_manager = new Dictionary<string, string>();
            listIdUserView = new List<string>();
            okr = new OKRs();
            krs = new List<KR>();
            status = -1;
        }
    }
}