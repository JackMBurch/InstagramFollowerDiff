using System.Text.Json.Serialization;

namespace InstagramFollowerDiff.Models
{

    public class FollowingRoot
    {
        [JsonPropertyName("relationships_following")]
        public List<Relationships> RelationshipsFollowing { get; set; } = [];
    }

    public class Relationships
    {
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        [JsonPropertyName("media_list_data")]
        public List<object> MediaListData { get; set; } = [];

        [JsonPropertyName("string_list_data")]
        public List<IGListItem> StringListData { get; set; } = [];
    }
}
