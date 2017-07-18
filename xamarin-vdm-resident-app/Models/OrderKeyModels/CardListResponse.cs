using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace VirtualDoorman.Models.OrderKeyModels
{
    public class CardListResponse
    {
		[JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("result")]
		public List<CardData> Result { get; set; }

		[JsonProperty("message")]
		public string Message { get; set; }
    }
}
