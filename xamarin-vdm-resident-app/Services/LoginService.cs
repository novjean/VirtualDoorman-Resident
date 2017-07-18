using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VirtualDoorman
{
    public class LoginService
    {
        private HttpClient _client = new HttpClient();

        public async Task<User> CheckLogin(LoginUser user){
            
            user.username = user.username.ToLower();
            string Url = getUrl() + $"[%7B\"username\":\"{user.username}\",\"password\":\"{user.password}\"%7D]";
            System.Diagnostics.Debug.WriteLine($"Url= {Url}");

            var response = await _client.GetAsync(Url);

            if (!response.Equals(null))
            {
                var content = await response.Content.ReadAsStringAsync();
                System.Diagnostics.Debug.WriteLine($"Content=  {content}");

				try{
					return JsonConvert.DeserializeObject<User>(content);
                }
                catch(Exception){
                    return null;
                }
            }
            else{
                return null;
            }

        }

        private string getUrl()
        {
            return "https://portal.virtualdoorman.com/dev/resident-api/login/";
        }
    }
}
