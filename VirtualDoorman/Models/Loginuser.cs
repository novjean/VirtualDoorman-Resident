using System;
namespace VirtualDoorman
{
    public class LoginUser
    {

		public string username { get; set; }
		public string password { get; set; }

		public LoginUser(string uname, string pass)
        {
            this.username = uname;
            this.password = pass;
        }

        public bool CheckInformation(){
            if (!this.username.Equals("") && !this.password.Equals(""))
                return true;
            else
                return false;
        }

    }
}
