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

            
            
        }

        public void RandomOpgave()
        {
            // Lav et program der:
            // 1. Genererer 5 tilfældige tal mellem 1 og 100
            // 2. Gemmer tallene i et array
            // 3. Udskriver tallene
            
            Console.WriteLine("\n=== Opgave 2: Random Tal Generator ===");

            
        }
        public void CharArrayOpgave()
        {
            // Lav et program der:
            // 1. Opretter et array med bogstaverne A-Z
            // 2. Udskriver hvert bogstavs ASCII-værdi
            // 3. Lader brugeren indtaste et tal og viser det tilsvarende bogstav
            
            Console.WriteLine("\n=== Opgave 3: Char Arrays og ASCII ===");
                       
            
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
            
            
        }
    }
}
