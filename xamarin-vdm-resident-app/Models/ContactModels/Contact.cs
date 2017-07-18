using System;
using Newtonsoft.Json;

namespace VirtualDoorman.Models.ContactModels
{
    public class Contact
    {
		[JsonProperty("FIRST_NAME")]
		public string FirstName { get; set; }

		[JsonProperty("DESCRIPTION")]
		public string Description { get; set; }

		[JsonProperty("PHONE_NO")]
		public string PhoneNo { get; set; }

		[JsonProperty("BUILDING_NAME")]
		public string BuildingName { get; set; }
    }
}
