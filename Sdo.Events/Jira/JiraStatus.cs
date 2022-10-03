﻿using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Threading.Tasks;
using Sdo.Events.Jira;

namespace Sdo.Events.Jira
{
    internal class JiraStatus
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("statusCategory")]
        public JiraStatusCategory StatusCategory { get; set; }
    }
}