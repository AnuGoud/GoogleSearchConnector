

using Newtonsoft.Json;
using System.Collections.Generic;

namespace GoogleDriveSearchConnector.Models
{
    public class GraphCollection<T>
    {
        [JsonProperty("value")]
        public List<T> Items { get; set; }
    }
}