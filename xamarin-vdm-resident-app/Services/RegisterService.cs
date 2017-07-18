using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using VirtualDoorman.Models;

namespace VirtualDoorman.Services
{
    public class RegisterService
    {
        public bool CheckUserRegisterInfo(RegisterUser user)
        {
            System.Diagnostics.Debug.WriteLine($"Inside CheckUserRegisterInfo");

            //Need to implement the checks
            //if (user.first_name.Equals(""))
                //return false;
            
            return true;
        }

        public bool CheckUserRegisterInfo2(RegisterUser user){
			System.Diagnostics.Debug.WriteLine($"Inside CheckUserRegisterInfo2");

			//Need to implement the checks
    //        if (user.apartment_number.Equals(""))
				//return false;

			return true;
        }

        public async Task<bool> PostResponse(RegisterUser user){

            System.Diagnostics.Debug.WriteLine("Inside Post");

            //RegisterUser test = createWorkingUser();

            //FormUrlEncodedContent test = new FormUrlEncodedContent((System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>)user);

            var _client = new HttpClient();

            var json = JsonConvert.SerializeObject(user);

            System.Diagnostics.Debug.WriteLine($"Json= {json.ToString()}");

            HttpContent httpContent = new StringContent(json);

            System.Diagnostics.Debug.WriteLine($"Content= {httpContent}");

            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

            var result = await _client.PostAsync(getUrl(), httpContent);

            System.Diagnostics.Debug.WriteLine($"Result= {result.IsSuccessStatusCode} , {result.ToString()} , {result.Headers.ToString()}");

            return result.IsSuccessStatusCode;
                                             
        }

        //private RegisterUser createWorkingUser()
        //{
        //    RegisterUser u = new RegisterUser();

        //    u.username = "testing.account";
        //    u.password = "password";
        //    u.first_name = "Jimmy";
        //    u.last_name = "John";
        //    u.primary_email = "jim@pizza.com";
        //    u.secondary_email = "jimmy@pizza.com";
        //    u.primary_phone = "1234543211";
        //    u.work_phone = "0987890987";
        //    u.cell_phone = "345678765";
        //    u.address = "121 Pizza Valley";
        //    u.street = "Pepperoni st";
        //    u.apartment_number = "200";
        //    u.state = "NY";
        //    u.city = "NY";
        //    u.country = "US";
        //    u.secret_question = "Which is the best Pizza?";
        //    u.secret_answer = "No Pizza";

        //    return u;
        //}

        public string getUrl(){
            return "https://portal.virtualdoorman.com/dev/resident-api/signup";
        }

    }
}
