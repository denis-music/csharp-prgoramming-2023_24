namespace FIT.Data
{
    public abstract class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Osoba(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }

        public abstract void Info();

        public virtual void PredstaviSe()
        {
            Console.WriteLine("Osoba se predstavlja");
        }
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}