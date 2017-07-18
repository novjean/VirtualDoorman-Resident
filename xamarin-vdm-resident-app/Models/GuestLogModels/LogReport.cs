using System;
using Newtonsoft.Json;

namespace VirtualDoorman.Models.GuestLogModels
{
    public class LogReport
    {
		[JsonProperty("is_read")]
		public string IsRead { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("date_time")]
		public string DateTime { get; set; }

		[JsonProperty("report_type")]
		public string ReportType { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("summary")]
		public string Summary { get; set; }

		[JsonProperty("operator_name")]
		public string OperatorName { get; set; }

	}
}
