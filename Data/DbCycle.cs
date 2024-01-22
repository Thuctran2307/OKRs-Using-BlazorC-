using MongoDB.Driver;
using OKRs.Data;

namespace OKRs.Model
{
    public class DbCycle
    {
        private static string _collectionName = "Cycle";

        public static async Task<Cycle> AddCycle(Cycle cycle)
        {
            var _db = Mongo.GetDatabase();

            var collection = _db.GetCollection<Cycle>(_collectionName);

            await collection.InsertOneAsync(cycle);

            return cycle;
        }

    }
}