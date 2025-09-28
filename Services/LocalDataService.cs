using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegisterLogin.Models;

namespace RegisterLogin
{
    internal class LocalDataService
    {
        private static LocalDataService instance;
        private User user;
        public static LocalDataService GetInstance()
        {
            if ( instance == null)
            {
                instance = new LocalDataService();
            }
            return instance;
        }
        public bool AddUser(User user)
        {
            this.user = user;
            return true;
        }
        public bool IsUserRegistered(string userName, string password)
        {
            if ( user != null)
            {
                if ( user.UserName == userName && user.Password == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
