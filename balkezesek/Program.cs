using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balkezesek
{
    class Program
    {
        static List<balkezesek> lista = new List<balkezesek>();
        static int be = 0;
        static void Beolvas()
        {
            StreamReader sr = new StreamReader("balkezesek.csv");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                lista.Add(new balkezesek(sr.ReadLine()));
            }
            sr.Close();
            foreach (var i in lista)
            {
                Console.WriteLine(i.Suly);
            }
        }

        static void Harmadik()
        {
            Console.WriteLine(lista.Count);
        }

        static void Negyedik()
        {
            foreach (var l in lista)
            {
                if (l.Utolso.Contains("1999-10"))
                {
                    Console.WriteLine($"{l.Nev}, {Math.Round(l.Magassag*2.54),1:N1}cm");
                }
            }
        }

        static void Otodik()
        {
            while (true)
            {
                Console.WriteLine("Írj be egy számot 1990 és 1999 között");
                int be = Convert.ToInt32(Console.ReadLine());
            if (be >= 1990 && be <= 1999)
            {
                Console.WriteLine("Jó számot adott meg");
                break;
            }
            else
            {
                Console.WriteLine("Rossz számot adtál meg");
            }
            }
        }

        static void Hatodik()
        {
            double suly = 0;
            double db = 0;
            foreach (var i in lista)
            {
                if (be>=int.Parse(i.Elso.Substring(0,4)) || be <= int.Parse(i.Elso.Substring(0, 4)))
                {
                    suly = suly + i.Suly;
                        db++;
                }
            }
            double atlag = suly / db;
            Console.WriteLine(atlag);
        }
        static void Main(string[] args)
        {
            //var b = new balkezesek("Jim Abbott","1989-04-08","1997-07-21",200,75);
            Beolvas();
            Console.WriteLine("3.feladat");
            Harmadik();
            Console.WriteLine("4.feladat");
            Negyedik();
            Console.WriteLine("5.feladat");
            Otodik();
            Console.WriteLine("6.feladat");
            Hatodik();
            Console.ReadLine();
        }
    }
}
