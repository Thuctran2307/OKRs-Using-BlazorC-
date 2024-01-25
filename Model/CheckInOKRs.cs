using System.Runtime.CompilerServices;
using MongoDB.Bson;

namespace OKRs.Model
{
    public class CheckInOKRs{

        [MongoDB.Bson.Serialization.Attributes.BsonId]
        public string id { get; set; }
        public string idOKRs { get; set; }

        public string idUserCheckIn { get; set; }

        // 0 : chekc in nháp
        // 1 : gửi bản check in đến quản lý
        // 2 : quản lý gửi lại bản checkin để xác nhận
        // 3 : check in thành công
        public int statusCheckIn { get; set; }

        public long dateCheckIn { get; set; }

        public CheckInOKRs(){
            id = ObjectId.GenerateNewId().ToString();
            statusCheckIn = -1;
        }

    }
}