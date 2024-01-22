using MongoDB.Driver;
using OKRs.Data;

namespace OKRs.Model
{
    public class DbProcess
    {
        private static string _collectionName = "Process";

        // add new process

        public static async Task<Process> AddProcess(Process process)
        {
            var _db = Mongo.GetDatabase();
            var collection = _db.GetCollection<Process>(_collectionName);
            await collection.InsertOneAsync(process);
            return process;
        }

    }
}