using Newtonsoft.Json;

namespace GoogleDriveSearchConnector.Models
{
    public class PayloadContent {
      [JsonProperty]
      public const string Type = "html";
      public string Value { get; set; }
    }
}
