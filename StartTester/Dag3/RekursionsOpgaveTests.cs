using Xunit;
using Opgaver;
using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Threading.Tasks;

namespace OpgaverTests.Dag3Tests
{
    public class RekursionsOpgaveTests
    {
        private readonly Dag3 _dag3;

        public RekursionsOpgaveTests()
        {
            _dag3 = new Dag3();
        }

        [Fact]
        public void BeregnFakultet_SkalReturnereKorrektResultat()
        {
            // Arrange
            var output = new StringWriter();

            // Act
            var task = Task.Run(() =>
            {
                Console.SetOut(output);
                _dag3.RekursionsOpgave();
            });
            task.Wait();

            string result = output.ToString();

            // Assert
            Assert.Contains("Fakultet af 5: 120", result);
        }

        [Fact]
        public void Nedtælling_SkalUdskriveTalIRigtigRækkefølge()
        {
            // Arrange
            var output = new StringWriter();

            // Act
            var task = Task.Run(() =>
            {
                Console.SetOut(output);
                _dag3.RekursionsOpgave();
            });
            task.Wait();

            string result = output.ToString();
            
            // Find linjer efter "Nedtælling fra 5:"
            var lines = result.Split('\n')
                             .SkipWhile(line => !line.Contains("Nedtælling fra 5:"))
                             .Skip(1) // Skip overskriften
                             .Take(6) // Tag kun de 6 tal (5,4,3,2,1,0)
                             .Select(line => line.Trim())
                             .Where(line => !string.IsNullOrWhiteSpace(line))
                             .Select(line => int.Parse(line))
                             .ToList();

            // Debug output
            Console.WriteLine("Found numbers:");
            Console.WriteLine(string.Join(", ", lines));

            // Assert
            Assert.Equal(6, lines.Count); // 5,4,3,2,1,0
            Assert.Equal(new[] { 5,4,3,2,1,0 }, lines);
        }
    }
} 