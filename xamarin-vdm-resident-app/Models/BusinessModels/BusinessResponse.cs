using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace VirtualDoorman.Models.BusinessModels
{
    public class BusinessResponse
    {
		[JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("result")]
		public List<Business> Result { get; set; }

		[JsonProperty("message")]
		public string Message { get; set; }
    }
}
