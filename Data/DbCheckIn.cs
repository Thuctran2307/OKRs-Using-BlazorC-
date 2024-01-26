using MongoDB.Driver;
using OKRs.Data;
using OKRs.Model;

namespace OKRs.Data
{
    public class DbCheckIn
    {
        private static string _collectionName = "CheckIn";

        // add Checkin

        public static async Task<CheckInOKRs> AddCheckIn(CheckInOKRs checkIn)
        {
            var _db = Mongo.GetDatabase();
            var collection = _db.GetCollection<CheckInOKRs>(_collectionName);
            await collection.InsertOneAsync(checkIn);
            return checkIn;
        }

        // get CHekcin by idOKRs

        public static async Task<CheckInOKRs> GetCheckIn(string idOKRs)
        {
            var _db = Mongo.GetDatabase();
            var collection = _db.GetCollection<CheckInOKRs>(_collectionName);
            var checkIn = await collection.FindAsync(x => x.idOKRs == idOKRs);
            if(checkIn == null){
                return new CheckInOKRs(idOKRs);
            }
            return checkIn.FirstOrDefault();
        }

        // update Checkin

        public static async Task<CheckInOKRs> UpdateCheckIn(CheckInOKRs checkIn)
        {
            var _db = Mongo.GetDatabase();
            var collection = _db.GetCollection<CheckInOKRs>(_collectionName);
            await collection.ReplaceOneAsync(x => x.idOKRs == checkIn.idOKRs, checkIn);
            return checkIn;
        }
    }
}