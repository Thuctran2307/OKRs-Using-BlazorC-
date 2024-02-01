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

        // GetListCycle
        public static async Task<List<Cycle>> GetListCycle()
        {
            var _db = Mongo.GetDatabase();
            var collection = _db.GetCollection<Cycle>(_collectionName);
            var cycles = await collection.Find(x => true).ToListAsync();
            return cycles;
        }

        // get Cycle last
        public static async Task<Cycle> GetCycleLast()
        {
            var _db = Mongo.GetDatabase();
            var collection = _db.GetCollection<Cycle>(_collectionName);
            var cycles = await collection.Find(x => true).SortByDescending(x => x.idCycle).Limit(1).ToListAsync();
            return cycles.FirstOrDefault();
        }

        // delete cycle

        public static async Task<bool> DeleteCycle(string idCycle)
        {
            var _db = Mongo.GetDatabase();
            var collection = _db.GetCollection<Cycle>(_collectionName);
            var filter = Builders<Cycle>.Filter.Eq("idCycle", idCycle);
            var result = await collection.DeleteOneAsync(filter);
            return result.DeletedCount != 0;
        }

        // update cycle
        public static async Task<bool> UpdateCycle(Cycle cycle)
        {
            var _db = Mongo.GetDatabase();
            var collection = _db.GetCollection<Cycle>(_collectionName);
            var filter = Builders<Cycle>.Filter.Eq("idCycle", cycle.idCycle);
            var update = Builders<Cycle>.Update
                .Set("nameCycle", cycle.nameCycle)
                .Set("startDate", cycle.dateStart)
                .Set("endDate", cycle.dateEnd)
                .Set("status", cycle.status);
            var result = await collection.UpdateOneAsync(filter, update);
            return result.ModifiedCount != 0;
        }

    }
}