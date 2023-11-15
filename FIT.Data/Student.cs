using System.Drawing;

namespace FIT.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string Indeks { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public Image Slika { get; set; }//byte[]
        public DateTime DatumRodjenja { get; set; }
        public bool Aktivan { get; set; }
        public int Semestar { get; set; }//SemestarId -- 1 - 8
        public override string ToString()
        {
            return $"{Indeks} {Ime} {Prezime}";
        }
    }
}
