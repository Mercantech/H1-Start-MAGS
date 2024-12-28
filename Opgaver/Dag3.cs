using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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

            UdskrivTalRække();
            GættespilMedWhileLoop();
        }

        public void UdskrivTalRække()
        {
            Console.WriteLine("\nTal 1-10 med for-loop:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void GættespilMedWhileLoop()
        {
            Console.WriteLine("\nGæt et tal mellem 1-10:");
            Random random = new Random();
            int hemmeligtTal = random.Next(1, 11);
            int gæt;
            int maxForsøg = 10;
            int forsøg = 0;

            while (forsøg < maxForsøg)
            {
                string input = Console.ReadLine();

                if (!ValiderInput(input, out gæt))
                {
                    continue;
                }

                forsøg++;
                string feedback = GivFeedback(gæt, hemmeligtTal, forsøg);
                Console.WriteLine(feedback);

                if (gæt == hemmeligtTal)
                {
                    return;
                }
            }

            Console.WriteLine(
                $"Du brugte alle {maxForsøg} forsøg. Det hemmelige tal var {hemmeligtTal}."
            );
        }

        private bool ValiderInput(string input, out int tal)
        {
            if (!int.TryParse(input, out tal))
            {
                Console.WriteLine("Ugyldigt input! Indtast et tal mellem 1 og 10.");
                return false;
            }

            if (tal < 1 || tal > 10)
            {
                Console.WriteLine("Tallet skal være mellem 1 og 10!");
                return false;
            }

            return true;
        }

        private string GivFeedback(int gæt, int hemmeligtTal, int forsøg)
        {
            if (gæt == hemmeligtTal)
            {
                return $"Tillykke! Du gættede tallet på {forsøg} forsøg!";
            }
            return gæt < hemmeligtTal ? "For lavt! Prøv igen." : "For højt! Prøv igen.";
        }

        public void MetodeOpgave()
        {
            Console.WriteLine("\n=== Opgave 2: Metoder ===");

            // Opret test-array
            int[] talArray = { 8, 15, 22, 38, 8, 91, 8, 1000, 42 };

            // Kald metoder og udskriv resultater
            double gennemsnit = BeregnGennemsnit(talArray);
            int størsteTal = FindStørsteTal(talArray);
            int antalOtter = TælForekomster(talArray, 8);

            // Udskriv resultater
            Console.WriteLine($"Gennemsnit: {gennemsnit:F2}");
            Console.WriteLine($"Største tal: {størsteTal}");
            Console.WriteLine($"Antal 8-taller: {antalOtter}");
        }

        /// <summary>
        /// Beregner gennemsnittet af alle tal i et array
        /// </summary>
        private double BeregnGennemsnit(int[] tal)
        {
            if (tal == null || tal.Length == 0)
            {
                return 0;
            }

            double sum = 0;
            foreach (int num in tal)
            {
                sum += num;
            }

            return sum / tal.Length;
        }

        /// <summary>
        /// Finder det største tal i et array
        /// </summary>
        private int FindStørsteTal(int[] tal)
        {
            if (tal == null || tal.Length == 0)
            {
                throw new ArgumentException("Array er tomt eller null");
            }

            int største = tal[0];
            for (int i = 1; i < tal.Length; i++)
            {
                if (tal[i] > største)
                {
                    største = tal[i];
                }
            }

            return største;
        }

        /// <summary>
        /// Tæller hvor mange gange et specifikt tal forekommer i arrayet
        /// </summary>
        private int TælForekomster(int[] tal, int søgeTal)
        {
            if (tal == null)
            {
                return 0;
            }

            int antal = 0;
            foreach (int num in tal)
            {
                if (num == søgeTal)
                {
                    antal++;
                }
            }

            return antal;
        }

        public void RekursionsOpgave()
        {
            Console.WriteLine("\n=== Opgave 3: Rekursion ===");

            // Test fakultet
            Console.WriteLine("Fakultet af 5: " + BeregnFakultet(5));

            // Test nedtælling
            Console.WriteLine("\nNedtælling fra 5:");
            Nedtælling(5);
        }

        /// <summary>
        /// Beregner fakultet af et tal rekursivt
        /// F.eks. 5! = 5 * 4 * 3 * 2 * 1 = 120
        /// </summary>
        private int BeregnFakultet(int n)
        {
            // Basistilfælde: 0! = 1 og 1! = 1
            if (n <= 1)
            {
                return 1;
            }

            // Rekursivt kald: n! = n * (n-1)!
            return n * BeregnFakultet(n - 1);
        }

        /// <summary>
        /// Udskriver en nedtælling rekursivt
        /// F.eks. 5,4,3,2,1,0
        /// </summary>
        private void Nedtælling(int n)
        {
            // Basistilfælde: Stop når vi når under 0
            if (n < 0)
            {
                return;
            }

            // Udskriv det aktuelle tal
            Console.WriteLine(n);

            // Rekursivt kald med n-1
            Nedtælling(n - 1);
        }

        public void TalSpil()
        {
            Console.WriteLine("\n=== Mini Projekt: Talspil ===");
            SpilEnRunde();
        }

        private void SpilEnRunde()
        {
            Random random = new Random();
            int hemmeligtTal = random.Next(1, 101); // Tal mellem 1-100
            int gæt;
            int forsøg = 0;
            int maxForsøg = 10;
            bool harVundet = false;

            Console.WriteLine("\nGæt et tal mellem 1-100!");
            Console.WriteLine($"Du har {maxForsøg} forsøg.");

            while (forsøg < maxForsøg)
            {
                // Læs og valider input
                string input = Console.ReadLine();
                if (!ValiderTalSpilInput(input, out gæt))
                {
                    continue;
                }

                forsøg++;

                // Giv feedback
                if (gæt == hemmeligtTal)
                {
                    Console.WriteLine($"Tillykke! Du gættede tallet på {forsøg} forsøg!");
                    harVundet = true;
                    break;
                }
                else
                {
                    string retning = gæt < hemmeligtTal ? "højere" : "lavere";
                    Console.WriteLine(
                        $"Tallet er {retning}! Du har {maxForsøg - forsøg} forsøg tilbage."
                    );
                }
            }

            if (!harVundet)
            {
                Console.WriteLine($"\nSpillet er slut! Det hemmelige tal var {hemmeligtTal}.");
            }

            // Spørg om spilleren vil spille igen
            SpørgOmNytSpil();
        }

        private bool ValiderTalSpilInput(string input, out int tal)
        {
            if (!int.TryParse(input, out tal))
            {
                Console.WriteLine("Ugyldigt input! Indtast venligst et tal mellem 1 og 100.");
                return false;
            }

            if (tal < 1 || tal > 100)
            {
                Console.WriteLine("Tallet skal være mellem 1 og 100!");
                return false;
            }

            return true;
        }

        private void SpørgOmNytSpil()
        {
            Console.WriteLine("\nVil du spille igen? (j/n)");
            string svar = Console.ReadLine().ToLower();

            if (svar == "j" || svar == "ja")
            {
                SpilEnRunde();
            }
            else if (svar == "n" || svar == "nej")
            {
                Console.WriteLine("Tak for spillet!");
            }
            else
            {
                Console.WriteLine("Ugyldigt input! Prøv venligst igen.");
                SpørgOmNytSpil();
            }
        }
    }
}
