﻿using FIT.Data;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.ConsoleApp.Nastava
{
    public class P4
    {

        public static void Pokreni()
        {
            //Reference();
            //Out();
            In();
        }

        private static void In()
        {
            Student denis = new Student("IB150051", "Denis", "Music");            
            AlocirajIInicijalizujStudentaIn(in denis);
            Console.WriteLine(denis.Indeks);
        }

        private static void AlocirajIInicijalizujStudentaIn(in Student obj)
        {
            //obj = new Student("IB150051", "Denis", "Music");
            obj.Indeks = "IB160061";

        }

        private static void Out()
        {
            Student denis;
            AlocirajIInicijalizujStudentaOut(out denis);

            int rezultat;
            if(int.TryParse("3215",out rezultat))
                Console.WriteLine($"Rezultat {rezultat}");

        }
        private static void AlocirajIInicijalizujStudentaOut(out Student obj)
        {
            obj = new Student("IB150051", "Denis", "Music");
        }

        private static void Reference()
        {
            Student denis = null;
            AlocirajIInicijalizujStudenta(ref denis);
        }

        private static void AlocirajIInicijalizujStudenta(ref Student obj)
        {
            obj = new Student("IB150051", "Denis", "Music");
        }
    }
}
