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
            /* Opgave 1: Arrays og Lister
             * 1. Opret et array med 5 forskellige dyrenavne
             * 2. Konverter arrayet til en List<string>
             * 3. Tilføj 3 nye dyrenavne til listen
             * 4. Sorter listen alfabetisk
             * 5. Udskriv hvert ord på en ny linje
             * 
             * Tips:
             * - Brug List<string> til at oprette listen
             * - Brug AddRange() eller Add() til at tilføje nye ord
             * - Brug Sort() til at sortere listen
             * - Brug foreach til at udskrive ordene
             */
        }

        public void DictionaryOpgave()
        {
            /* Opgave 2: Dictionary med Dyrelyde
             * 1. Opret et Dictionary med dyrelyde (f.eks. "hund" -> "vov")
             * 2. Tag imod input fra brugeren (et dyrenavn)
             * 3. Hvis dyret findes i dictionary, udskriv dyrets lyd
             * 4. Hvis dyret ikke findes, udskriv en passende besked
             * 
             * Tips:
             * - Brug Dictionary<string, string>
             * - Brug ToLower() på input for at gøre søgningen case-insensitive
             * - Brug ContainsKey() til at tjekke om dyret findes
             */
        }

        public void ControlFlowOpgave()
        {
            /* Opgave 3: Control Flow med Collections
             * 1. Opret en List<int>
             * 2. Tilføj 100 tilfældige tal mellem 1 og 1000
             * 3. For hvert tal, udskriv om det er lige eller ulige
             * 
             * Tips:
             * - Brug Random til at generere tilfældige tal
             * - Brug modulo (%) til at tjekke om et tal er lige
             * - Brug for-loop til at generere tallene
             */
        }

        public void OrdTaeller()
        {
            /* Mini Projekt: Ordtæller
             * 1. Tag imod en tekst fra brugeren
             * 2. Split teksten op i enkelte ord
             * 3. Tæl hvor mange gange hvert ord forekommer
             * 4. Udskriv statistik for hvert ord
             * 
             * Tips:
             * - Brug string.Split() til at dele teksten op
             * - Brug et Dictionary<string, int> til at tælle ordene
             * - Brug ToLower() for at gøre sammenligningen case-insensitive
             * - Husk at håndtere tegnsætning
             */
        }
    }
}
