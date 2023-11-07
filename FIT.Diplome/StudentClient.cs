namespace FIT.Diplome
{
    public class StudentClient
    {
        private readonly HttpClient httpClient;

        public StudentClient(HttpClient httpClient) {
            this.httpClient = httpClient;
        }

        public async Task<List<Student>> GetStudenti() {

             return await httpClient.GetFromJsonAsync<List<Student>>("api/student");
        
        }

    }
}
