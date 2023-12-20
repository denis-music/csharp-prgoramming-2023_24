namespace FIT.Data
{
    public class Semestar
    {
        public int Id { get; set; }
        public string Oznaka { get; set; }//1. - SEMESTAR
        public string Opis { get; set; }//1. - SEMESTAR - PRVOG CIKLUSA
        public bool Aktivan { get; set; }
        public override string ToString()
        {
            return Oznaka;
        }
    }
}
