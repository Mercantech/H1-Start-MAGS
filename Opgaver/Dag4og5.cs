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

            // Opret 8x8 array
            string[,] skakbraet = new string[8, 8];

            // Udfyld brættet
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if ((i + j) % 2 == 0)
                        skakbraet[i, j] = hvid;
                    else
                        skakbraet[i, j] = sort;
                }
            }

            // Udskriv brættet
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(skakbraet[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void BiografOpgave()
        {
            Console.WriteLine("\n=== Opgave 2: Biograf Booking ===");

            bool[,] biografSal = new bool[7, 12]; // false = ledig, true = optaget

            while (true)
            {
                // Vis salen
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < 12; j++)
                    {
                        Console.Write(biografSal[i, j] ? "X " : "O ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("\nVælg række (0-6) eller -1 for at afslutte:");
                int række = Convert.ToInt32(Console.ReadLine());
                if (række == -1)
                    break;

                Console.WriteLine("Vælg sæde (0-11):");
                int sæde = Convert.ToInt32(Console.ReadLine());

                if (række >= 0 && række < 7 && sæde >= 0 && sæde < 12)
                {
                    if (!biografSal[række, sæde])
                    {
                        biografSal[række, sæde] = true;
                        Console.WriteLine("Sæde booket!");
                    }
                    else
                    {
                        Console.WriteLine("Sædet er allerede optaget!");
                    }
                }
                else
                {
                    Console.WriteLine("Ugyldigt valg!");
                }
            }
        }

        public void DebugOpgave()
        {
            Console.WriteLine("\n=== Opgave 3: Debug Denne Kode ===");

            int[] talArray = new int[5] { 1, 2, 3, 4, 5 };

            try
            {
                // Rettet Fejl 1: Index out of range
                for (int i = 0; i < talArray.Length; i++)
                {
                    Console.WriteLine(talArray[i]);
                }

                // Rettet Fejl 2: Division by zero
                for (int i = 5; i > 0; i--)
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
            Console.WriteLine("\n=== Mini Projekt: Kryds og Bolle ===");

            char[,] bræt = new char[3, 3];
            bool spillerX = true;
            bool spilIgang = true;

            // Initialiser brættet
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    bræt[i, j] = ' ';

            while (spilIgang)
            {
                // Vis bræt
                VisBræt(bræt);

                // Spiller input
                Console.WriteLine($"Spiller {(spillerX ? 'X' : 'O')}'s tur");
                Console.Write("Række (0-2): ");
                int række = Convert.ToInt32(Console.ReadLine());
                Console.Write("Kolonne (0-2): ");
                int kolonne = Convert.ToInt32(Console.ReadLine());

                // Valider træk
                if (
                    række >= 0
                    && række < 3
                    && kolonne >= 0
                    && kolonne < 3
                    && bræt[række, kolonne] == ' '
                )
                {
                    bræt[række, kolonne] = spillerX ? 'X' : 'O';

                    // Check vinder
                    if (CheckVinder(bræt))
                    {
                        VisBræt(bræt);
                        Console.WriteLine($"Spiller {(spillerX ? 'X' : 'O')} har vundet!");
                        spilIgang = false;
                    }
                    else if (ErBrætFuldt(bræt))
                    {
                        VisBræt(bræt);
                        Console.WriteLine("Uafgjort!");
                        spilIgang = false;
                    }

                    spillerX = !spillerX;
                }
                else
                {
                    Console.WriteLine("Ugyldigt træk, prøv igen!");
                }
            }
        }

        private void VisBræt(char[,] bræt)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($" {bræt[i, 0]} | {bræt[i, 1]} | {bræt[i, 2]} ");
                if (i < 2)
                    Console.WriteLine("---+---+---");
            }
        }

        private bool CheckVinder(char[,] bræt)
        {
            // Check rækker og kolonner
            for (int i = 0; i < 3; i++)
            {
                if (bræt[i, 0] != ' ' && bræt[i, 0] == bræt[i, 1] && bræt[i, 1] == bræt[i, 2])
                    return true;
                if (bræt[0, i] != ' ' && bræt[0, i] == bræt[1, i] && bræt[1, i] == bræt[2, i])
                    return true;
            }

            // Check diagonaler
            if (bræt[0, 0] != ' ' && bræt[0, 0] == bræt[1, 1] && bræt[1, 1] == bræt[2, 2])
                return true;
            if (bræt[0, 2] != ' ' && bræt[0, 2] == bræt[1, 1] && bræt[1, 1] == bræt[2, 0])
                return true;

            return false;
        }

        private bool ErBrætFuldt(char[,] bræt)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (bræt[i, j] == ' ')
                        return false;
            return true;
        }
    }
}
