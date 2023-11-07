namespace FIT.Diplome
{
    public class Diploma
    {
        public int Id { get; set; }
        public string BrojDiplome { get; set; }
        public int StudentId { get; set; }
        public string StudentImePrezime { get; set;}
    }

    public class Student
    {
        public int Id { get; set; }
        public string ImePrezime { get; set; }
        public string BrojIndeksa { get; set; }
    }
}
