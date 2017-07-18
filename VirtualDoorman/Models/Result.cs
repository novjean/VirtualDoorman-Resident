using System;
using Newtonsoft.Json;

namespace VirtualDoorman
{
    public class Result
    {
        [JsonProperty("ID")]
        public string Id { get; set; }
        
		[JsonProperty("LOGIN_NAME")]
		public string Username { get; set; }

		[JsonProperty("USER_LEVEL")]
		public string UserLevel { get; set; }

		[JsonProperty("FIRST_NAME")]
		public string FirstName { get; set; }

		[JsonProperty("LAST_NAME")]
		public string LastName { get; set; }

        [JsonProperty("CELL_PHONE")]
        public string CellPhone { get; set; }

        [JsonProperty("building_address")]
        public string Street { get; set; }

        [JsonProperty("apartment_number")]
        public string ApartmentNumber { get; set; }

        [JsonProperty("state_name")]
        public string State { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("LOGIN_GUID")]
        public string LoginGUID { get; set; }

	}
}
