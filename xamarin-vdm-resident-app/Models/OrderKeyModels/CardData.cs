using System;
using Newtonsoft.Json;

namespace VirtualDoorman.Models.OrderKeyModels
{
    public class CardData
    {
		[JsonProperty("ID")]
		public string Id { get; set; }

		[JsonProperty("RESIDENT_ID")]
		public string ResidentId { get; set; }

		[JsonProperty("NAME")]
		public string Name { get; set; }

		[JsonProperty("NUMBER")]
		public string Number { get; set; }

		[JsonProperty("TYPE")]
		public string Type { get; set; }

		[JsonProperty("EXP_MONTH")]
		public string ExpiryMonth { get; set; }

		[JsonProperty("EXP_YEAR")]
		public string ExpiryYear { get; set; }

		[JsonProperty("BILLING_ADDRESS")]
		public string BillingAddress { get; set; }
    }
}
