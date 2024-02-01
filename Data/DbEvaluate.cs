using MongoDB.Driver;
using OKRs.Data;

namespace OKRs.Model
{
    public class DbEvaluate
    {
        private static string _collectionName = "Evaluate";

        // get all
        public static async Task<List<Evaluate>> GetAll()
        {
            var _db = Mongo.GetDatabase();
            var collection =  _db.GetCollection<Evaluate>(_collectionName);
            var list = await collection.Find(_ => true).ToListAsync();
            return list;
        }

        // add

        public static async Task<Evaluate> AddEvaluate(Evaluate evaluate)
        {
            var _db = Mongo.GetDatabase();
            var collection = _db.GetCollection<Evaluate>(_collectionName);
            await collection.InsertOneAsync(evaluate);
            return evaluate;
        }

        // UpdateEvaluate
        public static async Task<bool> UpdateEvaluate(Evaluate evaluate)
        {
            var _db = Mongo.GetDatabase();
            var collection = _db.GetCollection<Evaluate>(_collectionName);
            var result = await collection.ReplaceOneAsync(x => x.idEvaluate == evaluate.idEvaluate, evaluate);
            return result.IsAcknowledged;
        }

    }
}