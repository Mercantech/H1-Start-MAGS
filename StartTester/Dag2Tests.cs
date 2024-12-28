using Xunit;
using Opgaver;
using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace OpgaverTests.Dag2Tests
{
    [Collection("Sequential")]
    public class Dag2Tests
    {
        public readonly Dag2 _dag2;

        public Dag2Tests()
        {
            _dag2 = new Dag2();
        }
    
        [Fact]
        public void ArrayListOpgave_SkalHåndtereListerKorrekt()
        {
            // Arrange
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            _dag2.ArrayListOpgave();
            string output = consoleOutput.ToString();

            // Find alle linjer der kun indeholder enkelte ord
            var ord = output.Split('\n')
                           .Select(line => line.Trim())
                           .Where(line => !string.IsNullOrWhiteSpace(line) && 
                                         Regex.IsMatch(line, @"^[a-zæøå]+$"))
                           .ToList();

            // Debug output
            Console.WriteLine("Raw output:");
            Console.WriteLine(output);
            Console.WriteLine("\nFound words:");
            Console.WriteLine(string.Join("\n", ord));
            Console.WriteLine($"\nWord count: {ord.Count}");

            // Assert
            Assert.True(ord.Count >= 8, $"Der skal være mindst 8 ord, fandt kun {ord.Count}: {string.Join(", ", ord)}");
            Assert.Contains("hund", ord);
            Assert.Contains("kat", ord);
            
            // Check at listen er sorteret
            var sorteredOrd = ord.OrderBy(x => x).ToList();
            Assert.Equal(sorteredOrd, ord);
        }

        

        [Fact]
        public void DictionaryOpgave_SkalHåndtereFlereInputs()
        {
            // Arrange
            var testInput = "kat\n";
            var input = new StringReader(testInput);
            Console.SetIn(input);
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            _dag2.DictionaryOpgave();
            string output = consoleOutput.ToString().ToLower();

            // Assert
            Assert.Contains("miav", output);
        }

        [Fact]
        public void ControlFlowOpgave_SkalAnalysereTalKorrekt()
        {
            // Arrange
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            _dag2.ControlFlowOpgave();
            string output = consoleOutput.ToString();

            // Find antal lige og ulige tal
            var ligeTal = Regex.Matches(output, @"er et lige tal").Count;
            var uligeTal = Regex.Matches(output, @"er et ulige tal").Count;

            // Assert
            Assert.True(ligeTal > 0, "Ingen lige tal fundet");
            Assert.True(uligeTal > 0, "Ingen ulige tal fundet");
            Assert.Equal(100, ligeTal + uligeTal); // Total skal være 100 tal
        }

        [Fact]
        public void OrdTaeller_SkalTælleOrdKorrekt()
        {
            // Arrange
            var testTekst = "dette er en test dette er en test med flere ord test";
            var input = new StringReader(testTekst);
            Console.SetIn(input);
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            _dag2.OrdTaeller();
            string output = consoleOutput.ToString().ToLower();

            // Assert
            Assert.Contains("dette: 2", output);
            Assert.Contains("er: 2", output);
            Assert.Contains("test: 3", output);
            Assert.Contains("med: 1", output);
            Assert.Contains("flere: 1", output);
            Assert.Contains("ord: 1", output);
        }
    }
    [Collection("Sequential")]
    public class DictionaryOpgaveTests
    {
        public readonly Dag2 _dag2;

        public DictionaryOpgaveTests()
        {
            _dag2 = new Dag2();
        }

        [Fact]
        public void DictionaryOpgave_SkalHåndtereDyreLydeKorrekt()
        {
            // Arrange
            var testInput = "hund\n";
            var input = new StringReader(testInput);
            Console.SetIn(input);
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            _dag2.DictionaryOpgave();
            string output = consoleOutput.ToString();

            // Debug output
            Console.WriteLine("Actual output:");
            Console.WriteLine(output);

            // Assert
            Assert.Contains("vov", output.ToLower());
        }
    }
} 