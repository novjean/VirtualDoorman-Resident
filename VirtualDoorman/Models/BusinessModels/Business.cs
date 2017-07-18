using System;
using Newtonsoft.Json;

namespace VirtualDoorman.Models.BusinessModels
{
    public class Business
    {
		[JsonProperty("delivery_id")]
		public string DeliveryId { get; set; }

		[JsonProperty("ID")]
		public string Id { get; set; }

		[JsonProperty("LAST_NAME")]
		public string LastName { get; set; }

        [JsonProperty("FIRST_NAME")]
        public string FirstName { get; set; }

		[JsonProperty("PHONE")]
		public string Phone { get; set; }

		[JsonProperty("EMAIL")]
		public string Email { get; set; }

		[JsonProperty("permissions")]
		public string Permissions { get; set; }

		[JsonProperty("Notes")]
		public string Notes { get; set; }
    }
}
