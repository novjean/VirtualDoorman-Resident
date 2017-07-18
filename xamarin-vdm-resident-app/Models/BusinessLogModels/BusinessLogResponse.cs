using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace VirtualDoorman.Models.BusinessLogModels
{
    public class BusinessLogResponse
    {
		[JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("result")]
		public List<DeliveryReport> Result { get; set; }

		[JsonProperty("message")]
		public string Message { get; set; }
    }
}
