using MongoDB.Driver;

namespace OKRs.Data
{
    public class Mongo
    {
        public static IMongoDatabase GetDatabase()
        {
            var mongoClient = new MongoClient();

            try
            {
                return mongoClient.GetDatabase("OKRs");
            }
            catch
            {
                var databaseSettings = new MongoDatabaseSettings();
                var database = mongoClient.GetDatabase("OKRs", databaseSettings);
                return database;
            }
        }
    }
}

