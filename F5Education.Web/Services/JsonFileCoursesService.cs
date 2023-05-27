using F5Education.Web.Models;
using System.Text.Json;

namespace F5Education.Web.Services
{
    public class JsonFileCoursesService
    {
        public readonly IWebHostEnvironment _webHostEnvironment;
        public JsonFileCoursesService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        private string JsonFileName
        {
            get { return Path.Combine(_webHostEnvironment.WebRootPath, "data", "courses.json"); }
        }

        public IEnumerable<Course>? GetCourses()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                var results = JsonSerializer.Deserialize<Course[]>(jsonFileReader.ReadToEnd(),
                                       new JsonSerializerOptions
                                       {
                                           PropertyNameCaseInsensitive = true
                                       });
                return results;
            }
        }
    }
}
