using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver
{
    public class Dag4og5
    {
        public void Start()
        {
            // Da dag 5 er en kort dag, så er denne opgave en kombination af dag 4 og 5.
            // Der er dog også skruet op for sværhedsgraden, så der er også en del opgave der er tilbage til dag 5.

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\n Kører opgaver fra dag 4 & 5");

            Console.ForegroundColor = ConsoleColor.White;

            SkakbraetOpgave();

            BiografOpgave();

            DebugOpgave();

            KrydsOgBolle();
        }

        public void SkakbraetOpgave()
        {
            // Lav et program der:
            // 1. Opretter et 8x8 skakbræt som 2D array
            // 2. Udfylder det med 'sort' og 'hvid' felter
            // 3. Udskriver skakbrættet på en pæn måde

            Console.WriteLine("\n=== Opgave 1: Skakbræt ===");

            string hvid = "🔳";
            string sort = "🔲";
        }

        public void BiografOpgave()
        {
            // Lav et program der:
            // 1. Opretter en biografsal som 2D array (7x12)
            // 2. Gør det muligt for brugeren at booke sæder
            // 3. Viser ledige/optagne pladser

            Console.WriteLine("\n=== Opgave 2: Biograf Booking ===");
        }

        public void DebugOpgave()
        {
            Console.WriteLine("\n=== Opgave 3: Debug Denne Kode ===");

            // Denne metode indeholder bevidst fejl som skal findes og rettes
            Console.WriteLine("Find fejlene i denne kode:");

            int[] talArray = new int[5] { 1, 2, 3, 4, 5 };

            try
            {
                // Fejl 1: Index out of range
                for (int i = 0; i <= talArray.Length; i++)
                {
                    Console.WriteLine(talArray[i]);
                }

                // Fejl 2: Division by zero
                for (int i = 5; i >= 0; i--)
                {
                    int resultat = 10 / i;
                    Console.WriteLine(resultat);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"En fejl opstod: {ex.Message}");
                Console.WriteLine($"Stack trace: {ex.StackTrace}");
            }
        }

        public void KrydsOgBolle()
        {
            // Mini-projekt: Kryds og Bolle
            // 1. Opret et 3x3 spillebræt
            // 2. Lad to spillere skiftes til at placere X og O
            // 3. Check for vindere
            // 4. Implementer fejlhåndtering for ugyldige træk

            Console.WriteLine("\n=== Mini Projekt: Kryds og Bolle ===");
        }
    }
}
