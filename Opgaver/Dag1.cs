using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver
{
    public class Dag1
    {
        public void Start()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\n Kører opgaver fra dag 1");

            Console.ForegroundColor = ConsoleColor.White;

            StringOpgave();

            RandomOpgave();

            CharArrayOpgave();

            PasswordGenerator();
        }

        public void StringOpgave()
        {
            // Lav et program der:
            // 1. Beder brugeren om deres navn
            // 2. Konverterer navnet til store bogstaver
            // 3. Tæller antal bogstaver i navnet
            // 4. Udskriver resultatet

            Console.WriteLine("\n=== Opgave 1: String Manipulation ===");

            Console.WriteLine("Indtast dit navn: ");
            string navn = Console.ReadLine();

            string storeBogstaver = navn.ToUpper();
            int antalBogstaver = navn.Length;

            Console.WriteLine($"Navnet {storeBogstaver} har {antalBogstaver} bogstaver.");
        }

        public void RandomOpgave()
        {
            // Lav et program der:
            // 1. Genererer 5 tilfældige tal mellem 1 og 100
            // 2. Gemmer tallene i et array
            // 3. Udskriver tallene

            Console.WriteLine("\n=== Opgave 2: Random Tal Generator ===");

            Random random = new Random();
            int[] talArray = new int[5];

            for (int i = 0; i < 5; i++)
            {
                talArray[i] = random.Next(1, 101);
                Console.WriteLine($"Tal {i + 1}: {talArray[i]}");
            }
        }

        public void CharArrayOpgave()
        {
            // Lav et program der:
            // 1. Opretter et array med bogstaverne A-Z
            // 2. Udskriver hvert bogstavs ASCII-værdi
            // 3. Lader brugeren indtaste et tal og viser det tilsvarende bogstav

            Console.WriteLine("\n=== Opgave 3: Char Arrays og ASCII ===");

            // Opret array med A-Z
            char[] alfabetet = new char[26];
            for (int i = 0; i < 26; i++)
            {
                alfabetet[i] = (char)(65 + i); // 65 er ASCII for 'A'
                Console.WriteLine($"Bogstav: {alfabetet[i]}, ASCII: {(int)alfabetet[i]}");
            }

            Console.WriteLine("\nIndtast et tal mellem 65 og 90:");
            if (int.TryParse(Console.ReadLine(), out int asciiVærdi))
            {
                if (asciiVærdi >= 65 && asciiVærdi <= 90)
                {
                    char bogstav = (char)asciiVærdi;
                    Console.WriteLine($"ASCII {asciiVærdi} svarer til bogstavet: {bogstav}");
                }
            }
        }

        public void PasswordGenerator()
        {
            // Lav et program der:
            // 1. Genererer et tilfældigt password
            // 2. Gemmer passwordet i en variabel
            // 3. Udskriver passwordet
            // X. Udvid projektet til at kunne generere password med specielle tegn, tal, store og små bogstaver
            // samt længden af passwordet kan vælges af brugeren
            // Y. Kom med dine egne ideer til hvordan du vil udvide projektet

            Console.WriteLine("\n=== Mini Projekt: Password Generator ===");

            Console.WriteLine("Hvor langt skal passwordet være? (minimum 8 tegn)");
            if (!int.TryParse(Console.ReadLine(), out int længde) || længde < 8)
            {
                længde = 12; // Standard længde hvis input er ugyldigt
            }

            string storeBogstaver = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string småBogstaver = "abcdefghijklmnopqrstuvwxyz";
            string tal = "0123456789";
            string specialTegn = "!@#$%^&*()";

            Random random = new Random();
            char[] password = new char[længde];

            // Sikrer at vi har mindst ét af hver type
            password[0] = storeBogstaver[random.Next(storeBogstaver.Length)];
            password[1] = småBogstaver[random.Next(småBogstaver.Length)];
            password[2] = tal[random.Next(tal.Length)];
            password[3] = specialTegn[random.Next(specialTegn.Length)];

            // Fyld resten med tilfældige tegn
            string alleTegn = storeBogstaver + småBogstaver + tal + specialTegn;
            for (int i = 4; i < længde; i++)
            {
                password[i] = alleTegn[random.Next(alleTegn.Length)];
            }

            // Bland password
            for (int i = password.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                char temp = password[i];
                password[i] = password[j];
                password[j] = temp;
            }

            string færdigtPassword = new string(password);
            Console.WriteLine($"Dit genererede password er: {færdigtPassword}");
        }
    }
}
