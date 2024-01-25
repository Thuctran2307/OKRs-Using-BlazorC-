using MongoDB.Driver;
using OKRs.Data;

namespace OKRs.Model
{
    public class DbOKRs
    {
        private static string _collectionName = "_OKRs";

        // add new OKRs

        public static async Task<OKRs> AddOKRs(OKRs okrs)
        {
            var _db = Mongo.GetDatabase();

            var collection = _db.GetCollection<OKRs>(_collectionName);

            await collection.InsertOneAsync(okrs);

            return okrs;
        }

        // find KR by id

        public static async Task<OKRs> GetOKRsById(string id)
        {
            var _db = Mongo.GetDatabase();
            var collection = _db.GetCollection<OKRs>(_collectionName);
            var okrs = await collection.Find(x => x.idOKRs == id).FirstOrDefaultAsync();
            return okrs;
        }

        // get all OKRs

        public static async Task<List<OKRs>> GetAllOKRs()
        {
            var _db = Mongo.GetDatabase();
            var collection = _db.GetCollection<OKRs>(_collectionName);
            var okrs = await collection.Find(x => true).ToListAsync();
            return okrs;
        }

        // get all OKRs by idCycle
        public static async Task<List<OKRs>> GetAllOKRsByIdCycle(string idCycle, string idUser)
        {
            var _db = Mongo.GetDatabase();
            var collection = _db.GetCollection<OKRs>(_collectionName);
            var okrs = await collection.Find(x => x.idCycle == idCycle && x.idUser == idUser).ToListAsync();
            return okrs;
        }


        // Update okr

        public static async Task<OKRs> UpdateOKRs(OKRs okrs)
        {
            var _db = Mongo.GetDatabase();
            var collection = _db.GetCollection<OKRs>(_collectionName);
            await collection.ReplaceOneAsync(x => x.idOKRs == okrs.idOKRs, okrs);
            return okrs;
        }

        // delete okr
        public static async Task DeleteOKRs(string id)
        {
            var _db = Mongo.GetDatabase();
            var collection = _db.GetCollection<OKRs>(_collectionName);
            await collection.DeleteOneAsync(x => x.idOKRs == id);
        }
    }
}