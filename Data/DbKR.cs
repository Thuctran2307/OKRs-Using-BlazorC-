using MongoDB.Driver;
using OKRs.Data;

namespace OKRs.Model
{
    public class DbKR
    {
        private static string _collectionName = "KR";

        // add new KRs

        public static async Task<KR> AddKRs(KR kr)
        {
            var _db = Mongo.GetDatabase();

            var collection = _db.GetCollection<KR>(_collectionName);

            await collection.InsertOneAsync(kr);

            return kr;
        }

        // GetAllKRs

        public static async Task<List<KR>> GetAllKRs()
        {
            var _db = Mongo.GetDatabase();
            var collection = _db.GetCollection<KR>(_collectionName);
            var kr = await collection.Find(x => true).ToListAsync();
            return kr;
        }


        // Delete by id
        public static async Task DeleteKRs(string id)
        {
            var _db = Mongo.GetDatabase();
            var collection = _db.GetCollection<KR>(_collectionName);
            await collection.DeleteOneAsync(x => x.idKR == id);
        }

        // Update KR

        public static async Task<KR> UpdateKRs(KR kr)
        {
            var _db = Mongo.GetDatabase();
            var collection = _db.GetCollection<KR>(_collectionName);
            await collection.ReplaceOneAsync(x => x.idKR == kr.idKR, kr);
            return kr;
        }

        // deleteAllKr by idOKrs

        public static async Task DeleteAllKRsByIdOkr(string idOKRs)
        {
            var _db = Mongo.GetDatabase();
            var collection = _db.GetCollection<KR>(_collectionName);
            await collection.DeleteManyAsync(x => x.idOKRs == idOKRs);
        }

    }
}