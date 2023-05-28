using F5Education.Web.Models;
using F5Education.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace F5Education.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public readonly JsonFileCoursesService CoursesService;
        public IEnumerable<Course>? Courses { get; set; }

        public IndexModel(ILogger<IndexModel> logger, JsonFileCoursesService jsonFileCoursesService)
        {
            _logger = logger;
            CoursesService = jsonFileCoursesService;
        }

        public void OnGet()
        {
            Courses = CoursesService.GetCourses();
        }
    }
}