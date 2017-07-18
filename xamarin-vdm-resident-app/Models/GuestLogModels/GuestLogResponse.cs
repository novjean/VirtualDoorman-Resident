using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace VirtualDoorman.Models.GuestLogModels
{
    public class GuestLogResponse
    {
		[JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("result")]
		public List<LogReport> Result { get; set; }

		[JsonProperty("message")]
		public string Message { get; set; }
    }
}
