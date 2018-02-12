using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace CodePathShortner.Models
{
    public class CreateRequestModel
    {
        [JsonProperty(PropertyName="url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "friendly_id", Required = Required.Default)]
        public string FriendlyId { get; set; }
    }
}