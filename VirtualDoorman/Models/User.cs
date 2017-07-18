using System;
using Newtonsoft.Json;

namespace VirtualDoorman
{
    public class User
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("result")]
        public Result Result { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

    }
}
