using MongoDB.Driver;
using OKRs.Data;
using OKRs.Model;

namespace OKRs.Service
{
    public class S_User
    {
        private static string _collectionName = "User";
        public static bool CheckUserIsAvailable(string id){

            var _db = Mongo.GetDatabase();
            var collection = _db.GetCollection<User>(_collectionName);
            var user = collection.Find(x => x.userId == id).FirstOrDefault();
            if(user != null){
                return true;
            }

             return false;
        }

    }
}