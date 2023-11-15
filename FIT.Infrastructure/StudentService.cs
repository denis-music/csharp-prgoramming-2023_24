using FIT.Data;

using System.ComponentModel;

namespace FIT.Infrastructure
{

    public class KonekcijaNaBazu 
    {

    }
    public class StudentService
    {
        KonekcijaNaBazu db = new KonekcijaNaBazu();
        public cStudent GetByBrojIndeksa(string indeks)
        {
            cStudent student = new cStudent()
            {
                Indeks = indeks,
                Ime = "Ime",
                Prezime = "Prezime"
            };
            //return student;
            return null;
        }

        public List<cStudent> GetByGodinaStudija(int godinaStudija)
        {
            int brojac = 0;
            return new List<cStudent>()
            {
                new cStudent(){ Indeks = $"IB{230000 + brojac}", Ime = $"Ime{brojac}", Prezime = $"Prezime{brojac++}" },
                new cStudent(){ Indeks = $"IB{230000 + brojac}", Ime = $"Ime{brojac}", Prezime = $"Prezime{brojac++}" },
                new cStudent(){ Indeks = $"IB{230000 + brojac}", Ime = $"Ime{brojac}", Prezime = $"Prezime{brojac++}" },
            };

            //List<Student> list = new List<Student>();
            //list.Add(new Student() { Indeks = $"IB{230000 + brojac}", Ime = $"Ime{brojac}", Prezime = $"Prezime{brojac++}" });
            //list.Add(new Student() { Indeks = $"IB{230000 + brojac}", Ime = $"Ime{brojac}", Prezime = $"Prezime{brojac++}" });
            //list.Add(new Student() { Indeks = $"IB{230000 + brojac}", Ime = $"Ime{brojac}", Prezime = $"Prezime{brojac++}" });
            //return list;
        }
    }
}