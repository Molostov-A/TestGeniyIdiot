using System.Collections.Generic;
using GeniyIdiot.Common.Models;

namespace GeniyIdiot.Common
{
    public class UsersStorage
    {
        private JsonProvider storageCurrentUser = new("current_user");
        private Dictionary<string, string> userSpecialists = new()
        {
            {"admin", "12345"}
        };

        public User GetCurrentUser()
        {
            return storageCurrentUser.Read<User>();
        }

        public void RewriteCurrentUser(string name)
        {
            User currentUser = new User(name);
            storageCurrentUser.Write(currentUser);
        }

        public bool Autorization(string password, string currentName)
        {
            if (userSpecialists[currentName] == password)
            {
                return true;
            }
            return false;
        }
    }
}
