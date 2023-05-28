using F5Education.Web.Models;
using F5Education.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace F5Education.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        public readonly JsonFileCoursesService _jsonFileCoursesService;
        public readonly ILogger<CoursesController> _logger;
        public CoursesController(JsonFileCoursesService JsonFileCoursesService, ILogger<CoursesController> logger)
        {
            _jsonFileCoursesService = JsonFileCoursesService;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Course>? GetCourses()
        {
            return _jsonFileCoursesService.GetCourses();
        }
    }
}
