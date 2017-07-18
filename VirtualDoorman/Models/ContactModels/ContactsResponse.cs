using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace VirtualDoorman.Models.ContactModels
{
    public class ContactsResponse
    {
		[JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("result")]
		public List<Contact> Result { get; set; }

		[JsonProperty("message")]
		public string Message { get; set; }
    }
}
