using System.Text.Json.Serialization;

namespace IdeaCenter23._04._2026.Models
{
    internal class IdeaCenterDTO
    {
        [JsonPropertyName("title")]

        public string? Title { get; set; }

        [JsonPropertyName("description")]

        public string? Description { get; set; }

        [JsonPropertyName("url")]

        public string? Url { get; set; }

    }
}