using System;
using Newtonsoft.Json;

namespace VirtualDoorman.Models.GuestModels
{
    public class GuestPermissions
    {
        [JsonProperty("permission_unformatted")]
        public string PermissionUnformatted { get; set; }

		[JsonProperty("permission_type_day")]
		public string PermissionTypeDay { get; set; }

		[JsonProperty("permission_day")]
		public string PermissionDay { get; set; }

		[JsonProperty("permission_type_time")]
		public string PermissionTypeTime { get; set; }

		[JsonProperty("permission_time")]
		public string PermissionTime { get; set; }
    }
}
