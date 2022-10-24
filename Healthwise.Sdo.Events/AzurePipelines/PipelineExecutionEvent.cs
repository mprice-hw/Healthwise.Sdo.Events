﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Healthwise.Sdo.Events.AzurePipelines
{
    public class PipelineExecutionEvent : EventBase
    {
        [Required]
        [JsonProperty("name")]
        public string PipelineName { get; set; }

        [Required]
        [JsonProperty("runId")]
        public int RunId { get; set; }

        [Required]
        [JsonProperty("teamName")]
        public string TeamName { get; set; }

        [Required]
        [JsonProperty("serviceName")]
        public string ServiceName { get; set; }
        
        [Required]
        [JsonProperty("serviceVersion")]
        public string ServiceVersion { get; set; }

        [Required]
        [JsonProperty("repoName")]
        public string RepoName { get; set; }

        [Required]
        [JsonProperty("branchName")]
        public string BranchName { get; set; }

        [Required]
        [JsonProperty("commitHash")]
        public string CommitHash { get; set; }

        [Required]
        [JsonProperty("state")]
        public PipelineState State { get; set; }

        [Required]
        [JsonProperty("result")]
        public PipelineResult Result { get; set; }
    }
}
