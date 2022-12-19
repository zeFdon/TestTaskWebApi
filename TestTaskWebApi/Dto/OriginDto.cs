﻿using Newtonsoft.Json;

namespace TestTaskWebApi.Dto
{
    [Serializable]
    public class OriginDto
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("dimension")]
        public string Dimension { get; set; }
        
    }
}
