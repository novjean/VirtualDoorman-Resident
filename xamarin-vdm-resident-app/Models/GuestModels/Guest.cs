using System;
using Newtonsoft.Json;
using VirtualDoorman.Models.GuestModels;

namespace VirtualDoorman.Models
{
    public class Guest
    {
        [JsonProperty("guest_id")]
        public string GuestId { get; set; }

        [JsonProperty("ID")]
        public string Id { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LastName { get; set; }

		[JsonProperty("FIRST_NAME")]
		public string FirstName { get; set; }

		[JsonProperty("EMAIL")]
		public string Email { get; set; }

		[JsonProperty("PHONE")]
		public string Phone { get; set; }

        [JsonProperty("ALT_PHONE")]
        public string altPhone { get; set; }

        [JsonProperty("WORK_PHONE")]
        public string workPhone { get; set; }

        [JsonProperty("CELL_PHONE")]
        public string CellPhone { get; set; }

		[JsonProperty("NOTES")]
		public string Notes { get; set; }

		[JsonProperty("SECRET_QUESTION")]
		public string SecretQuestion { get; set; }

		[JsonProperty("PASSCODE")]
		public string Passcode { get; set; }

		[JsonProperty("CELL_PHONE_PROVIDER")]
		public string CellPhoneProvider { get; set; }

        [JsonProperty("permissions")]
        public GuestPermissions permission { get; set; }
    }
}
