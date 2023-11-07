using FIT.Data;

using System.ComponentModel;

namespace FIT.Infrastructure
{

    public class InMemoryDb
    {
        public static List<Korisnik> Korisnici = GenerisiKorisnike();

        private static List<Korisnik> GenerisiKorisnike()
        {
            //var korisnik = new Korisnik()
            //{
            //    Id = 1,
            //    Aktivan = true,
            //    Email = "admin@edu.fit.ba",
            //    Ime = "Denis",
            //    KorisnickoIme = "admin",
            //    Lozinka = "admin",
            //    Prezime = "Music"
            //};
            //List<Korisnik> lista = new List<Korisnik>();
            //lista.Add(korisnik);
            //return lista;

            return new List<Korisnik>(){
                new Korisnik()
                    {
                        Id = 1,
                        Aktivan = true,
                        Email = "admin@edu.fit.ba",
                        Ime = "Denis",
                        KorisnickoIme = "admin",
                        Lozinka = "admin",
                        Prezime = "Music"
                    }
            };
        }
    }








    public class KonekcijaNaBazu 
    {

    }
    public class StudentService
    {
        KonekcijaNaBazu db = new KonekcijaNaBazu();
        public Student GetByBrojIndeksa(string indeks)
        {
            Student student = new Student()
            {
                Indeks = indeks,
                Ime = "Ime",
                Prezime = "Prezime"
            };
            //return student;
            return null;
        }

        public List<Student> GetByGodinaStudija(int godinaStudija)
        {
            int brojac = 0;
            return new List<Student>()
            {
                new Student(){ Indeks = $"IB{230000 + brojac}", Ime = $"Ime{brojac}", Prezime = $"Prezime{brojac++}" },
                new Student(){ Indeks = $"IB{230000 + brojac}", Ime = $"Ime{brojac}", Prezime = $"Prezime{brojac++}" },
                new Student(){ Indeks = $"IB{230000 + brojac}", Ime = $"Ime{brojac}", Prezime = $"Prezime{brojac++}" },
            };

            //List<Student> list = new List<Student>();
            //list.Add(new Student() { Indeks = $"IB{230000 + brojac}", Ime = $"Ime{brojac}", Prezime = $"Prezime{brojac++}" });
            //list.Add(new Student() { Indeks = $"IB{230000 + brojac}", Ime = $"Ime{brojac}", Prezime = $"Prezime{brojac++}" });
            //list.Add(new Student() { Indeks = $"IB{230000 + brojac}", Ime = $"Ime{brojac}", Prezime = $"Prezime{brojac++}" });
            //return list;
        }
    }
}