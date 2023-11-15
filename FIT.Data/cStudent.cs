using System.Collections;
using System.Reflection.Emit;

namespace FIT.Data
{
    public class cStudent : Osoba, IEnumerable, IDisposable
    {
        public cStudent():base(Vrijednosti.NotSet, Vrijednosti.NotSet)
        {
            Indeks = Vrijednosti.NotSet;
        }
        public cStudent(string indeks,string ime, string prezime):base(ime,prezime)
        {
            Indeks = indeks;
        }

        public int[] Ocjene = new int[] { 6, 6, 8, 9, 7 };
        public int this[int lokacija] {
            get { return Ocjene[lokacija]; }
        }
        public string Indeks { get; set; }      
        public int ? Fakultet { get; set; }       

        public override string ToString()
        {
            return $"{Indeks} {base.ToString()}";
        }

        public override void Info()
        {
            Console.WriteLine("Hello from info");
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Ocjene.Length; i++)
                yield return Ocjene[i];
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose -> " + ToString());
        }
    }

    public class sStudent
    {
        public string Indeks { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public override string ToString()
        {
            return $"{Indeks} {Ime} {Prezime}";
        }
    }
}