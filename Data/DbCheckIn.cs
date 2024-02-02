using MongoDB.Driver;
using OKRs.Data;
using OKRs.Model;

namespace OKRs.Data
{
    public class DbCheckIn
    {
        private static string _collectionName = "CheckIn";

        // add Checkin

        public static async Task<bool> Add(CheckInOKRs checkIn)
        {
            try{
                var _db = Mongo.GetDatabase();
                var collection = _db.GetCollection<CheckInOKRs>(_collectionName);
                collection.InsertOne(checkIn);
                return true;
            }
            catch(Exception e){
                return false;
            }
        }

        // get all checkin by idUser
        public static async Task<List<CheckInOKRs>> GetAll(string idUser)
        {
            var _db = Mongo.GetDatabase();
            var collection = _db.GetCollection<CheckInOKRs>(_collectionName);
            var checkIn = await collection.Find(x => x.idUser == idUser).ToListAsync();
            return checkIn;
        }

        // get CHekcin by idOKRs
        public static CheckInOKRs GetCheckInLasted(string idOKRs)
        {
            var _db = Mongo.GetDatabase();
            var collection = _db.GetCollection<CheckInOKRs>(_collectionName);
            var checkIn = collection.Find(x => x.okr.idOKRs == idOKRs).SortByDescending(x => x.dateCheckIn).FirstOrDefault();
            return checkIn;
        }

        // update Checkin

        public static void Update(CheckInOKRs checkIn)
        {
            var _db = Mongo.GetDatabase();
            var collection = _db.GetCollection<CheckInOKRs>(_collectionName);
            collection.ReplaceOne(x => x.id == checkIn.id, checkIn);
        }

        // GetCheckInOKRsByUserCheckIn

        public static List<CheckInOKRs> GetCheckInOKRsByUser(string idUser)
        {
            var _db = Mongo.GetDatabase();
            var collection = _db.GetCollection<CheckInOKRs>(_collectionName);
            var checkIn = collection
                .Find(x => x.idUser == idUser)
                .SortByDescending(x => x.dateCheckIn)
                .ToList() // Add ToList() to convert the result to a list
                .GroupBy(x => x.okr.idOKRs)
                .Select(x => x.First())
                .ToList();
            return checkIn;
        }
    }
}