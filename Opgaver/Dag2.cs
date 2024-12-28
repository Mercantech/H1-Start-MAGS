using System;
using System.Collections.Generic;
using System.Linq;

namespace Opgaver
{
    public class Dag2
    {
        public void Start()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Kører opgaver fra dag 2");
            Console.ForegroundColor = ConsoleColor.White;

            ArrayListOpgave();
            DictionaryOpgave();
            ControlFlowOpgave();
            OrdTaeller();
        }

        public void ArrayListOpgave()
        {
            Console.WriteLine("\n=== Opgave 1: Arrays og Lister ===");

            // 1. Opret array med 5 ord
            string[] ordArray = { "hund", "kat", "mus", "fugl", "fisk" };

            // 2. Konverter til List og tilføj nye ord
            List<string> ordListe = new List<string>(ordArray);

            // 3. Tilføj 3 nye ord
            string[] nyeOrd = { "kanin", "hamster", "skildpadde" };
            ordListe.AddRange(nyeOrd);

            // 4. Sorter listen
            ordListe.Sort();

            // 5. Udskriv kun den endelige sorterede liste
            foreach (string ord in ordListe)
            {
                Console.WriteLine(ord);
            }
        }

        public void DictionaryOpgave()
        {
            //Console.WriteLine("\n=== Opgave 2: Dictionary med Dyrelyde ===");

            var dyreLyde = new Dictionary<string, string>
            {
                { "hund", "vov" },
                { "kat", "miav" },
                { "ko", "muh" },
                { "gris", "øf" }
            };

            string dyr = Console.ReadLine().ToLower().Trim();

            if (dyreLyde.ContainsKey(dyr))
            {
                Console.WriteLine($"{dyr} siger: {dyreLyde[dyr]}");
            }
            else
            {
                Console.WriteLine($"Jeg kender ikke lyden af en {dyr}");
            }
        }

        public void ControlFlowOpgave()
        {
            Console.WriteLine("\n=== Opgave 3: Control Flow med Collections ===");

            List<int> tal = new List<int>();
            Random random = new Random();

            // Generér 100 tilfældige tal
            for (int i = 0; i < 100; i++)
            {
                tal.Add(random.Next(1, 1001));
            }

            // Analyser tallene
            foreach (int nummer in tal)
            {
                if (nummer % 2 == 0)
                {
                    Console.WriteLine($"{nummer} er et lige tal");
                }
                else
                {
                    Console.WriteLine($"{nummer} er et ulige tal");
                }
            }
        }

        public void OrdTaeller()
        {
            Console.WriteLine("\n=== Mini Projekt: Ordtæller ===");

            Console.WriteLine("Indtast en tekst:");
            string tekst = Console.ReadLine().ToLower();

            // Split teksten i ord og fjern tegnsætning
            string[] ord = tekst.Split(
                new[] { ' ', '.', ',', '!', '?' },
                StringSplitOptions.RemoveEmptyEntries
            );

            // Tæl forekomster af hvert ord
            Dictionary<string, int> ordTæller = new Dictionary<string, int>();

            foreach (string Enkeltord in ord)
            {
                if (ordTæller.ContainsKey(Enkeltord))
                {
                    ordTæller[Enkeltord]++;
                }
                else
                {
                    ordTæller[Enkeltord] = 1;
                }
            }

            // Udskriv resultatet
            foreach (var pair in ordTæller)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
