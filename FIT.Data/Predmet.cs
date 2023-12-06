namespace FIT.Data
{
    public class Predmet
    {
        public int Id { get; set; }
        public int Semestar { get; set; }
        public string Naziv { get; set; }

        // public List<Student> PoloziliPredmet { get; set; }
        public override string ToString()
        {
            return Naziv;
        }
    }
}
