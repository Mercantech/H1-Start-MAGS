using Xunit;
using Opgaver;
using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace OpgaverTests.Dag1Tests
{
    [Collection("Sequential")]
    public class Dag1Tests
    {
        private readonly Dag1 _dag1;

        public Dag1Tests()
        {
            _dag1 = new Dag1();
        }

        [Theory]
        [InlineData("test", "TEST", 4)]
        [InlineData("Peter", "PETER", 5)]
        [InlineData("Anna-Marie", "ANNA-MARIE", 10)]
        public void StringOpgave_SkalKonvertereOgTælleKorrekt(string input, string forventetOutput, int forventetLængde)
        {
            // Arrange
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);
            Console.SetIn(new StringReader(input));

            // Act
            _dag1.StringOpgave();
            string output = consoleOutput.ToString();

            // Assert
            Assert.Contains(forventetOutput, output);
            Assert.Contains(forventetLængde.ToString(), output);
        }

        [Fact]
        public void RandomOpgave_SkalGenerereFemTalMellem1Og100()
        {
            // Arrange
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            _dag1.RandomOpgave();
            string output = consoleOutput.ToString();

            // Udtræk kun tal efter "Tal X: " mønsteret
            var numbers = Regex.Matches(output, @"Tal \d+: (\d+)")
                              .Cast<Match>()
                              .Select(m => int.Parse(m.Groups[1].Value))
                              .ToList();

            // Assert
            Assert.Equal(5, numbers.Count);
            Assert.All(numbers, num => Assert.InRange(num, 1, 100));
        }

        [Theory]
        [InlineData(65, 'A')]
        [InlineData(90, 'Z')]
        [InlineData(77, 'M')]
        public void CharArrayOpgave_SkalHåndtereASCIIKorrekt(int asciiVærdi, char forventetBogstav)
        {
            // Arrange
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);
            Console.SetIn(new StringReader(asciiVærdi.ToString()));

            // Act
            _dag1.CharArrayOpgave();
            string output = consoleOutput.ToString();

            // Assert
            Assert.Contains(asciiVærdi.ToString(), output);
            Assert.Contains(forventetBogstav.ToString(), output);
        }

        [Fact]
        public void PasswordGenerator_SkalGenererGyldigtPassword()
        {
            // Arrange
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);
            Console.SetIn(new StringReader("12")); // Antager at vi beder om et 12-tegn password

            // Act
            _dag1.PasswordGenerator();
            string output = consoleOutput.ToString();

            // Find password i output ved at lede efter linjen med det genererede password
            var passwordLine = output.Split('\n')
                .FirstOrDefault(line => line.Contains("Dit genererede password er:"));
            
            if (passwordLine != null)
            {
                string password = passwordLine.Split(':')[1].Trim();

                // Assert
                Assert.True(password.Length >= 8);
                Assert.Matches(@"[A-Z]", password);
                Assert.Matches(@"[a-z]", password);
                Assert.Matches(@"[0-9]", password);
                Assert.Matches(@"[!@#$%^&*()]", password);
            }
            else
            {
                Assert.True(false, "Kunne ikke finde det genererede password i output");
            }
        }
    }
}
