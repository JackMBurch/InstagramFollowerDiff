using System.Text.Json.Serialization;

namespace InstagramFollowerDiff.Models
{
    public class IGListItem
    {
        [JsonPropertyName("href")]
        public string Link { get; set; } = string.Empty;

        [JsonPropertyName("value")]
        public string User { get; set; } = string.Empty;

        [JsonPropertyName("timestamp")]
        public int Timestamp { get; set; }
    }
}
