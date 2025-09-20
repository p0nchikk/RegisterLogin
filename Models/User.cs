using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterLogin.Models
{
    public class User
    {
		private int userID;
        private string userName;
        private string password;
        private string userEmail;

        public int UserID
		{
			get { return userID; }
			set { userID = value; }
		}
		public string UserName
		{
			get { return userName; }
			set { userName = value; }
		}

		public string Password
		{
			get { return password; }
			set { password = value; }
		}

		public string UserEmail
		{
			get { return userEmail; }
			set { userEmail = value; }
		}
		public string GetUserInfo()
		{
			return $"User ID: {this.userID}, Username: {this.userName}, Email: {this.UserEmail}. ";
		}
	}
}
