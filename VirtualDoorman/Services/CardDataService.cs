using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using VirtualDoorman.Models.OrderKeyModels;

namespace VirtualDoorman.Services
{
    public class CardDataService
    {
		private HttpClient _client = new HttpClient();

        async public Task<CardListResponse> RetreiveCardListData(string loginGUID){

            Contract.Ensures(Contract.Result<Task>() != null);
			Debug.WriteLine($"Guest L:og Service for Login GUID: {loginGUID}");
			string Url = getUrl() + $"[%7B\"login_guid\":\"{loginGUID}\"%7D]";
			Debug.WriteLine($"Url = {Url}");

            var response = await _client.GetAsync(Url);
			if (!response.Equals(null))
			{
				var content = await response.Content.ReadAsStringAsync();
				Debug.WriteLine($"Content = {content}");

				try
				{
					Debug.WriteLine("Converting Content...");
					return JsonConvert.DeserializeObject<CardListResponse>(content);
				}
				catch (Exception err)
				{
					Debug.WriteLine($"CardDataService Exception: {err}");
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
            return "https://portal.virtualdoorman.com/dev/resident-api/resident_credit_cards/";
        }
    }
}
