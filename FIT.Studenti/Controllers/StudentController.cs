using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FIT.Studenti.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        public static List<Student> studenti = new List<Student>()
        {
            new Student(){Id = 1, BrojIndeksa = "IB150051", ImePrezime ="Denis Music"},
            new Student(){Id = 2, BrojIndeksa = "IB150052", ImePrezime ="Jasmin Azemovic"},

        };
        [HttpGet]
        public ActionResult<List<Student>> Get()
        {
            return studenti;
        }

    }
}
