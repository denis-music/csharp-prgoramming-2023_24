namespace FIT.Data
{
    public class Uloga { 
        public int Id { get; set; }
        public string Naziv { get; set; }

        public ICollection<Student> Student { get; set; } = new HashSet<Student>();
        public override string ToString()
        {
            return Naziv;
        }
    }
}
