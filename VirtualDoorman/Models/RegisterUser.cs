using System;
namespace VirtualDoorman.Models
{
    public class RegisterUser
    {
		public string username { get; set; }
		public string password { get; set; }

        public string first_name { get; set; }
		public string last_name { get; set; }

		public string primary_email { get; set; }
		public string secondary_email { get; set; }
		public string primary_phone { get; set; }
		public string work_phone { get; set; }
		public string cell_phone { get; set; }

        public string address { get; set; }
		public string street { get; set; }	
        public string apartment_number { get; set; }
        public string state { get; set; }
		public string city { get; set; }
		public string country { get; set; }

		public string secret_question { get; set; }
        public string secret_answer { get; set; }

		public RegisterUser()
        {
            
        }
    }
}
