using System.Diagnostics;
using OKRs.Model;
using System.Collections.Generic; // Add this line to import List<T>

namespace OKRs.Service
{
    public class HandleUser
    {
        private static List<User> users;

        static HandleUser()
        {
            InitializeUsers();
        }

        private static async void InitializeUsers()
        {
            users = await DbUser.GetAllUser();
        }

        public static List<User> GetAllUser()
        {
            return users;
        }
    }
}
