using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using VirtualDoorman.Models.BusinessLogModels;

namespace VirtualDoorman.Services
{
    public class BusinessLogService
    {
        private HttpClient _client = new HttpClient();

        async public Task<BusinessLogResponse> RetrieveDeliveryLogs(User user){

			Contract.Ensures(Contract.Result<Task>() != null);
			Debug.WriteLine($"Guest Service for Login GUID: {user.Result.LoginGUID}");
			string Url = getUrl() + $"[%7B\"login_guid\":\"{user.Result.LoginGUID}\"%7D]";
			Debug.WriteLine($"Url = {Url}");

			var response = await _client.GetAsync(Url);
			if (!response.Equals(null))
			{
				var content = await response.Content.ReadAsStringAsync();
				Debug.WriteLine($"Content = {content}");

				try
				{
					Debug.WriteLine("Converting Content...");
                    return JsonConvert.DeserializeObject<BusinessLogResponse>(content);
				}
				catch (Exception err)
				{
					Debug.WriteLine($"BusinessLogService Exception: {err}");
					return null;
				}
			}
			else
			{
				Debug.WriteLine("Reponse was null");
				return null;
			}

        }

		private string getUrl()
		{
			return "https://portal.virtualdoorman.com/dev/resident-api/resident_deliveries_reports/";
		}

    }
}
