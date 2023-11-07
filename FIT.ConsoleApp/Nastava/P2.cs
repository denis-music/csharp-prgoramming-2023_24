using FIT.Data;
using FIT.Infrastructure;

using System;

namespace FIT.ConsoleApp.Nastava
{

    public class P2
    {
        public static void Pokreni()
        {
            //BazniTip();
            //Override();
            //Slojevi();
            //VrijednostiReference();
            //Nizovi();
            //PodrazumijevaneVrijednosti();
            ProvjeraNullVrijednosti();
        }

        private static void ProvjeraNullVrijednosti()
        {
            StudentService studentService = new StudentService();
            Student student = studentService.GetByBrojIndeksa("IB220022");
            //student?.Semestri[1]?.Uplate[3]?.Iznos            
            Console.WriteLine(student?.Prezime);
            // uslov_ispunjen ? DA : NE;
            string ime = student?.Ime ?? "<NOT SET>" ;


        }
        private static void PodrazumijevaneVrijednosti()
        {
            Student denis = null;
            denis.Indeks = "IB230032";
            Student jasmin = new Student();
            jasmin.Indeks = "IB230032";

            int ? a = null;
            Nullable<int> godina = null;
            if(godina.HasValue)
                Console.WriteLine(godina.Value);
        }
        private static void Nizovi()
        {
            int[] ocjene = new int[3];
            ocjene[0] = 1;

            sStudent[] prvaGodina = new sStudent[3];
            Student[] drugaGodina = new Student[3];

            for (int i = 0; i < prvaGodina.Length; i++)
            {
                prvaGodina[i].Indeks = $"IB{230000 + i}";
                prvaGodina[i].Ime = $"Ime{i}";
                prvaGodina[i].Prezime = $"Prezime{i}";
            }
            for (int i = 0; i < drugaGodina.Length; i++)
            {
                drugaGodina[i] = new Student();
                drugaGodina[i].Indeks = $"IB{230000 + i}";
                drugaGodina[i].Ime = $"Ime{i}";
                drugaGodina[i].Prezime = $"Prezime{i}";
                drugaGodina[i].Fakultet = null;

            }


        }
        private static void VrijednostiReference()
        {
            Student denis1 = new Student() { Indeks = $"IB{230000}", Ime = $"Ime", Prezime = $"Prezime" };
            Student denis2 = denis1;
            denis2.Indeks = "IB230032";
            Console.WriteLine(denis1);
            Console.WriteLine(denis2);


            sStudent jasmin1 = new sStudent() { Indeks = $"IB{230000}", Ime = $"Ime", Prezime = $"Prezime" };
            sStudent jasmin2 = jasmin1;
            jasmin2.Indeks = "IB230032";
            Console.WriteLine(jasmin1);
            Console.WriteLine(jasmin2);
        }
        private static void Slojevi()
        {
            StudentService studentService = new StudentService();
            Student student = studentService.GetByBrojIndeksa("IB220022");
            Console.WriteLine(student);
        }
        private static void Override()
        {
            Student denis = new Student();           

            Console.WriteLine(denis);
            Console.WriteLine(denis.ToString());

        }
        private static void BazniTip()
        {
            int godina = 2023;
            Student denis = new Student();

            object oGodina = godina;
            object oDenis = denis;
            FromObject(denis);
            FromObject(godina);
        }
        private static void FromObject(object obj)
        {
            if(obj is Student)
            { 
               (obj as Student).PredstaviSe();
            }
            else if (obj is int)
                Console.WriteLine("Int");

        }
    }

}
