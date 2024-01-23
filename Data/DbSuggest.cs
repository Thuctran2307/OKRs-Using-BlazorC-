using MongoDB.Driver;
using OKRs.Data;

namespace OKRs.Model
{
    public class DbSuggest
    {
        private static string _collectionName = "Suggest";

        // add new Suggest

        public static async Task<Suggest> AddSuggest(Suggest suggest)
        {
            var _db = Mongo.GetDatabase();
            var collection = _db.GetCollection<Suggest>(_collectionName);
            await collection.InsertOneAsync(suggest);
            return suggest;
        }

        // get all suggestions

        public static async Task<List<Suggest>> GetListSuggest()
        {
            var _db = Mongo.GetDatabase();
            var collection = _db.GetCollection<Suggest>(_collectionName);
            var suggests = await collection.Find(x => true).ToListAsync();
            return suggests;
        }
    }
}