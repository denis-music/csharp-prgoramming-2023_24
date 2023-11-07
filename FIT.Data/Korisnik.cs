namespace FIT.Data
{

    public class BazniEntitet
    {
        //bad2391c-08a7-4239-a100-6bbd91da36e6
        public DateTime Kreiran { get; set; }
        public int KreiraoID { get; set; }
        public DateTime Modifikovan { get; set; }
        public int ModifikovaoID { get; set; }
    }

    public class Korisnik //: BazniEntitet
    {
        public int Id { get; set; }//5
        public string Ime { get; set; }//Denis //Goran
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string Email { get; set; }
        public bool Aktivan { get; set; }
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }

    }
   

}
