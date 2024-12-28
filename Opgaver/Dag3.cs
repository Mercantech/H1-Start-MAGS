using System;

namespace Opgaver
{
    public class Dag3
    {
        public void Start()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Kører opgaver fra dag 3");
            Console.ForegroundColor = ConsoleColor.White;

            LoopBasics();
            MetodeOpgave();
            RekursionsOpgave();
            TalSpil();
        }

        public void LoopBasics()
        {
            Console.WriteLine("\n=== Opgave 1: Loop Basics ===");
            /* TODO: 
             * 1. Lav metoden UdskrivTalRække():
             *    - Brug et for-loop til at udskrive tallene 1-10
             *    
             * 2. Lav metoden GættespilMedWhileLoop():
             *    - Computeren vælger et tilfældigt tal mellem 1-10
             *    - Brugeren har max 10 forsøg
             *    - Giv feedback (for højt/lavt)
             *    - Stop ved korrekt gæt eller når der ikke er flere forsøg
             */

            
        }
        public void GættespilMedWhileLoop(){
            return;
        }

        public void UdskrivTalRække(){
            return;
        }

        public void MetodeOpgave()
        {
            Console.WriteLine("\n=== Opgave 2: Metoder ===");
            /* TODO:
             * Implementer følgende metoder der arbejder med arrays:
             * 
             * 1. BeregnGennemsnit(int[] tal)
             *    - Returner gennemsnittet af alle tal i arrayet
             *    - Husk at håndtere tomme arrays
             * 
             * 2. FindStørsteTal(int[] tal)
             *    - Find og returner det største tal i arrayet
             *    - Kast ArgumentException hvis array er tomt
             * 
             * 3. TælForekomster(int[] tal, int søgeTal)
             *    - Tæl hvor mange gange søgeTal findes i arrayet
             */
        }

        public void RekursionsOpgave()
        {
            Console.WriteLine("\n=== Opgave 3: Rekursion ===");
            /* TODO:
             * Implementer følgende rekursive metoder:
             * 
             * 1. BeregnFakultet(int n)
             *    - Beregn n! (n fakultet)
             *    - F.eks. 5! = 5 * 4 * 3 * 2 * 1 = 120
             *    - Husk basistilfælde (n <= 1)
             * 
             * 2. Nedtælling(int n)
             *    - Udskriv tallene fra n ned til 0
             *    - Brug rekursion i stedet for loop
             */
        }

        public void TalSpil()
        {
            Console.WriteLine("\n=== Mini Projekt: Talspil ===");
            /* TODO: Grundet naturen af spillet, har den ikke en unit test.
             * Lav et gættespil hvor:
             * 1. Computeren vælger et tilfældigt tal mellem 1-100
             * 2. Brugeren har 10 forsøg til at gætte tallet
             * 3. Ved hvert gæt skal programmet fortælle om tallet er:
             *    - For højt
             *    - For lavt
             *    - Korrekt
             * 4. Spillet skal stoppe når:
             *    - Tallet er gættet, eller
             *    - Der ikke er flere forsøg
             * 
             * Krav:
             * - Valider brugerens input (kun tal mellem 1-100)
             * - Vis antal resterende forsøg
             * - Vis det korrekte tal når spillet er slut
             */
        }
    }
}

