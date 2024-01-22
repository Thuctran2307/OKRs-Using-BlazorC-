
using MongoDB.Driver;
using OKRs.Data;

namespace OKRs.Model
{
    public class DbUser
    {
        private static string _collectionName = "User";

        // add new user
        public static async Task<User> AddUser(User user)
        {
            var _db = Mongo.GetDatabase();

            var collection = _db.GetCollection<User>(_collectionName);

            await collection.InsertOneAsync(user);

            return user;
        }

        // check user exists by id

        public static async Task<User> GetUserById(string id)
        {
            var _db = Mongo.GetDatabase();

             var collection = _db.GetCollection<User>(_collectionName);

             var user = await collection.Find(x => x.userId == id).FirstOrDefaultAsync();

             return user;
        }

        // check user by username and password

        public static async Task<User> GetUserByUsernameAndPassword(string username, string password)
        {
            var _db = Mongo.GetDatabase();
            var collection = _db.GetCollection<User>(_collectionName);
            var user = await collection.Find(x => x.userName == username && x.password == password).FirstOrDefaultAsync();
            return user;
        }

        // GetUserByUsername

        public static async Task<User> GetUserByUsername(string username)
        {
            var _db = Mongo.GetDatabase();
            var collection = _db.GetCollection<User>(_collectionName);
            var user = await collection.Find(x => x.userName == username).FirstOrDefaultAsync();
            return user;
        }


    }
}