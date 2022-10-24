using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Healthwise.Sdo.Events
{
    public class EventBase
    {
        [Required]
        [JsonProperty("source")]
        public string Source { get; set; }

        [Required]
        [JsonProperty("type")]
        public string Type { get; set; }

        [Required]
        [JsonProperty("version")]
        public string Version { get; set; }
        
        [Required]
        [JsonProperty("sourceId")]
        public string SourceId { get; set; }

        [Required]
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTimeOffset Timestamp { get; set; }
    }
}
