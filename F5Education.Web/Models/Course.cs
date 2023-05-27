using System.Text.Json;
using System.Text.Json.Serialization;

namespace F5Education.Web.Models
{
    public class Course
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        [JsonPropertyName("school_name")]
        public string SchoolName { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Course>(this);
    }
}
