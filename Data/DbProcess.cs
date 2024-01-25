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

        // get Process lasted

        public static async Task<Process> GetProcessLasted(string id)
        {
            var _db = Mongo.GetDatabase();
            var collection = _db.GetCollection<Process>(_collectionName);

            // Sắp xếp theo thời gian giảm dần và chỉ lấy bản ghi đầu tiên
            var process = await collection
                .Find(x => x.idOKRs == id)
                .SortByDescending(x => x.date)  // Giả sử Timestamp là trường lưu ngày dưới dạng long
                .FirstOrDefaultAsync();

            return process;
        }


        // getALlProcess

        public static async Task<List<Process>> GetAllProcess()
        {
            var _db = Mongo.GetDatabase();
            var collection = _db.GetCollection<Process>(_collectionName);
            var list = await collection.FindAsync(_ => true);
            return list.ToList();
        }

        // update process

        public static async Task<Process> UpdateProcess(Process process)
        {
            var _db = Mongo.GetDatabase();
            var collection = _db.GetCollection<Process>(_collectionName);
            await collection.ReplaceOneAsync(x => x.idProcess == process.idProcess, process);
            return process;
        }

        // check if process is existing
        public static async Task<bool> CheckProcess(string idProcess)
        {
            var _db = Mongo.GetDatabase();
            var collection = _db.GetCollection<Process>(_collectionName);
            var process = await collection.FindAsync(x => x.idProcess == idProcess);
            return process.Any();
        }
    }
}