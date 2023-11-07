using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FIT.Diplome.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiplomaController : ControllerBase
    {

        public static List<Diploma> diplome = new List<Diploma>()
        {
            new Diploma(){Id = 1, BrojDiplome="FIT125/23", StudentId = 1 },
            new Diploma(){Id = 2, BrojDiplome="FIT126/23", StudentId = 2 },

        };
        private readonly StudentClient studentClient;

        public DiplomaController(StudentClient studentClient)
        {
            this.studentClient = studentClient;
        }
        [HttpGet]
        public async Task<List<Diploma>> Get()
        {
            var studenti = await studentClient.GetStudenti();
            diplome[0].StudentImePrezime = studenti.Where(x => x.Id == diplome[0].StudentId).First().ImePrezime;
            return diplome;
        }
    }
}
