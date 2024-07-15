﻿using Newtonsoft.Json;

namespace NopStation.Plugin.ExternalAuth.Google.Areas.Admin.Models
{
    public record GoogleUserDTO
    {
        [JsonProperty("algorithm")]
        public string Algorithm { get; set; }

        [JsonProperty("expires")]
        public int Expires { get; set; }

        [JsonProperty("issued_at")]
        public int IssuedAt { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
