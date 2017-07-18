using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace VirtualDoorman.Models
{
    public class GuestResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

		[JsonProperty("result")]
		public List<Guest> Result { get; set; }

		[JsonProperty("message")]
		public string Message { get; set; }
    }
}
