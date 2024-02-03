using System.Runtime.CompilerServices;
using MongoDB.Bson;

namespace OKRs.Model
{
    public class CheckInOKRs{

        [MongoDB.Bson.Serialization.Attributes.BsonId]
        public string id { get; set; }
        public OKRs okr { get; set; }

        public List<KR> krs { get; set; }

        public Dictionary<string,List<string>> answersKr { get; set; }

        // -1: mẫu
        // 0 : chekc in nháp
        // 1 : gửi bản check in đến quản lý
        // 2 : quản lý gửi lại bản checkin để xác nhận
        // 3 : check in thành công
        public string idUser { get; set; }
        public string idUserCheckIn { get; set; }
        public int statusCheckIn { get; set; }

        public long dateCheckIn { get; set; }

        public double progress { get; set; }

        public long nextCheckIn { get; set; }

        public List<Chat> chats { get; set; }

        public CheckInOKRs(){
            id = ObjectId.GenerateNewId().ToString();
            krs = new List<KR>();
            answersKr = new Dictionary<string, List<string>>();
            chats = new List<Chat>();
            statusCheckIn = -1;
        }

    }
}